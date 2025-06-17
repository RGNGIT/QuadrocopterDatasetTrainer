using MathNet.Numerics.IntegralTransforms;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics.Statistics;

namespace QuadrocopterDatasetTrainer.Audio
{
    public class AudioProcessor
    {
        public class SoundAnalysisResult
        {
            public string FileName { get; set; }
            public float MinFrequencyHz { get; set; }
            public float MaxFrequencyHz { get; set; }
            public float NoiseLevelDb { get; set; }
            public float SignalPowerWatt { get; set; }
            public float SignalToNoiseRatioDb { get; set; }
            public float SuitabilityLevelPercent { get; set; }
            public string SuitabilityLabel => SuitabilityLevelPercent >= 85 ? "Высокая" :
                                              SuitabilityLevelPercent >= 65 ? "Средняя" : "Низкая";
        }

        public static float Clamp(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        public SoundAnalysisResult AnalyzeSoundFile(string filePath)
        {
            using (var reader = new AudioFileReader(filePath))
            {
                var floatList = new List<float>();
                var buffer = new float[4096];
                int read;
                while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
                    floatList.AddRange(buffer.Take(read));

                var samples = floatList.ToArray();
                floatList.Clear();
                floatList = null;

                int fftSize = 1;
                while (fftSize < samples.Length) fftSize *= 2;

                var padded = new float[fftSize];
                Array.Copy(samples, padded, samples.Length);

                var fftBuffer = padded.Select(x => new MathNet.Numerics.Complex32(x, 0)).ToArray();
                Fourier.Forward(fftBuffer, FourierOptions.Matlab);
                padded = null;

                float sampleRate = reader.WaveFormat.SampleRate;
                float freqResolution = sampleRate / fftSize;

                var magnitudes = fftBuffer.Take(fftSize / 2).Select(c => (float)c.Magnitude).ToArray();
                fftBuffer = null;

                float threshold = 0.00001f;
                var significantFreqs = magnitudes
                    .Select((mag, i) => new { Index = i, Magnitude = mag })
                    .Where(p => p.Magnitude > threshold)
                    .Select(p => p.Index * freqResolution)
                    .ToList();

                float minFreq = significantFreqs.Any() ? significantFreqs.Min() : 0;
                float maxFreq = significantFreqs.Any() ? significantFreqs.Max() : 0;

                float rms = (float)Math.Sqrt(samples.Select(x => x * x).Average());
                float signalPower = rms * rms;

                var noisePower = samples
                    .Where(x => Math.Abs(x) < 0.01f)
                    .Select(x => x * x)
                    .DefaultIfEmpty(0)
                    .Average();

                float snr = 10f * (float)Math.Log10(signalPower / (noisePower + 1e-6f));
                float suitability = Clamp(signalPower * snr * 200, 0, 100);

                samples = null;
                magnitudes = null;
                significantFreqs = null;

                GC.Collect();

                return new SoundAnalysisResult
                {
                    FileName = Path.GetFileName(filePath),
                    MinFrequencyHz = minFreq,
                    MaxFrequencyHz = maxFreq,
                    SignalPowerWatt = signalPower,
                    NoiseLevelDb = 10 * (float)Math.Log10(noisePower + 1e-6f),
                    SignalToNoiseRatioDb = snr,
                    SuitabilityLevelPercent = suitability
                };
            }
        }

        public static AudioFileReader GetReader(string path) 
        {
            var audioReader = new AudioFileReader(path);
            return audioReader;
        }

        public Dictionary<double, double> ProcessAudio(string filePath, out Dictionary<double, double> audioSpecter) 
        {
            FFT fft = new FFT();
            var fftData = fft.RunFFTOnFile(filePath, out audioSpecter);

            return fftData;
        }

        public Dictionary<double, double> ProcessFrequencyAmplitudes(string filePath) 
        {
            FFT fft = new FFT();
            var fftData = fft.RunFrequencyAmp(filePath);

            return fftData;
        }

        public void BuildChart(Dictionary<double, double> source, Chart chart, string series, int toTake) 
        {
            chart.Series.Clear();
            chart.Series.Add(series);

            foreach (var chunk in source.Take(toTake))
            {
                chart.Series[series].Points.AddXY(chunk.Key, chunk.Value);
            }
        }
    }
}
