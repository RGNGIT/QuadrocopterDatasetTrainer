using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuadrocopterDatasetTrainer.Audio
{
    internal class AudioProcessor
    {
        public Dictionary<double, double> ProcessAudio(string filePath) 
        {
            FFT fft = new FFT();
            var fftData = fft.RunFFTOnFile(filePath);

            return fftData;
        }

        public void BuildChart(Dictionary<double, double> source, Chart chart, string series, int toTake) 
        {
            foreach (var chunk in source.Take(toTake))
            {
                chart.Series[series].Points.AddXY(chunk.Key, chunk.Value);
            }
        }
    }
}
