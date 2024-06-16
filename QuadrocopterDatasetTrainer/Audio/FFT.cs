using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using MathNet.Numerics.IntegralTransforms;
using System.Windows.Forms;
using NAudio.Dsp;
using NAudio.MediaFoundation;
using System.Numerics;

namespace QuadrocopterDatasetTrainer.Audio
{
    internal class FFT
    {
        public Dictionary<double, double> RunFrequencyAmp(string filePath)
        {
            int sampleRate = 44100; 
            using (var audioFileReader = new AudioFileReader(filePath))
            {
                float[] buffer = new float[audioFileReader.Length / 4];
                int bytesRead = audioFileReader.Read(buffer, 0, buffer.Length);
                int fftLength = 1024; 
                double[] fftBuffer = new double[fftLength];
                Dictionary<double, double> frequencyAmplitudes = new Dictionary<double, double>();

                for (int i = 0; i < buffer.Length; i += fftLength)
                {
                    if (i + fftLength > buffer.Length)
                        break;

                    Array.Copy(buffer, i, fftBuffer, 0, fftLength);

                    System.Numerics.Complex[] complexBuffer = fftBuffer.Select(v => new System.Numerics.Complex(v, 0)).ToArray();
                    Fourier.Forward(complexBuffer, FourierOptions.Matlab);
                    for (int j = 0; j < complexBuffer.Length / 2; j++)
                    {
                        double frequency = j * sampleRate / fftLength;
                        if (frequency >= 20 && frequency <= 20000)
                        {
                            double amplitude = complexBuffer[j].Magnitude;
                            if (!frequencyAmplitudes.ContainsKey(frequency))
                            {
                                frequencyAmplitudes[frequency] = amplitude;
                            }
                            else
                            {
                                frequencyAmplitudes[frequency] = (frequencyAmplitudes[frequency] + amplitude) / 2;
                            }
                        }
                    }
                }

                return frequencyAmplitudes;
            }
        }

        public Dictionary<double, double> RunFFTOnFile(string filePath, out Dictionary<double, double> audioSpecter) 
        {
            Runtime.Logger($"Началось преобразование Фурье файла ({filePath})");
            Dictionary<double, double> amplitudeSpecterResult = new Dictionary<double, double>();
            Dictionary<double, double> audioSpecterResult = new Dictionary<double, double>();

            using (var audioReader = new AudioFileReader(filePath)) 
            {
                int sampleRate = audioReader.WaveFormat.SampleRate;
                int channels = audioReader.WaveFormat.Channels;
                int bytesPerSample = audioReader.WaveFormat.BitsPerSample / 8;
                int sampleCount = (int)audioReader.Length / bytesPerSample;

                Runtime.Logger($"streamLength = {(int)audioReader.Length} bitsPerSample = {audioReader.WaveFormat.BitsPerSample} sampleRate = {sampleRate} channels = {channels} bytesPerSample = {bytesPerSample} sampleCount = {sampleCount}");

                float[] audioData = new float[sampleCount];
                audioReader.Read(audioData, 0, sampleCount);

                if (channels == 2) 
                {
                    float[] monoAudioData = new float[sampleCount / 2];
                    for (int i = 0; i < sampleCount; i += 2)
                    {
                        monoAudioData[i / 2] = (audioData[i] + audioData[i + 1]) / 2.0f;
                    }
                    audioData = monoAudioData;
                    sampleCount = sampleCount / 2;

                    Runtime.Logger($"Сигнал стерео, преобразовано с усреднением каналов. sampleCount = {sampleCount}");
                }
                
                System.Numerics.Complex[] complexes = new System.Numerics.Complex[sampleCount];
                for (int i = 0; i < sampleCount; i++) 
                {
                    complexes[i] = new System.Numerics.Complex(audioData[i], 0.0);
                }

                Fourier.Forward(complexes, FourierOptions.NumericalRecipes);

                double[] amplitudes = new double[sampleCount];
                for (int i = 0; i < sampleCount; i++)
                {
                    amplitudes[i] = complexes[i].Magnitude;
                }

                for (int i = 0; i < amplitudes.Length; i++)
                {
                    amplitudeSpecterResult.Add(i, amplitudes[i]);
                }

                for (int i = 0; i < audioData.Length; i++)
                {
                    audioSpecterResult.Add(i, audioData[i]);
                }
            }

            audioSpecter = audioSpecterResult;
            return amplitudeSpecterResult;
        }
    }
}
