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
        public Dictionary<double, double> RunFFTOnFile(string filePath) 
        {
            Runtime.Logger($"Началось преобразование Фурье файла ({filePath})");
            Dictionary<double, double> specterResult = new Dictionary<double, double>();

            using (var audioReader = new AudioFileReader(filePath)) 
            {
                int sampleRate = audioReader.WaveFormat.SampleRate;
                int channels = audioReader.WaveFormat.Channels;
                int bytesPerSample = audioReader.WaveFormat.BitsPerSample / 8;
                int sampleCount = (int)audioReader.Length / bytesPerSample;

                Runtime.Logger($"sampleRate = {sampleRate} channels = {channels} bytesPerSample = {bytesPerSample} sampleCount = {sampleCount}");

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

                Fourier.Forward(complexes, FourierOptions.Matlab);

                double[] amplitudes = new double[sampleCount];
                for (int i = 0; i < sampleCount; i++)
                {
                    amplitudes[i] = complexes[i].Magnitude;
                }

                for (int i = 0; i < amplitudes.Length; i++)
                {
                    specterResult.Add(i, amplitudes[i]);
                }
            }

            return specterResult;
        }
    }
}
