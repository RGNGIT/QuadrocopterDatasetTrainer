using QuadrocopterDatasetTrainer.Audio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadrocopterDatasetTrainer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Runtime.SetLoggerObject(logger);

            chartMain.Series.Clear();
            chartFrequencyAmplitudes.Series.Clear();
            chartAmplitude.Series.Clear();
            chartColateral.Series.Clear();

            chartMain.Series.Add("Аудио спектр");
            chartFrequencyAmplitudes.Series.Add("Частотный спектр");    
            chartAmplitude.Series.Add("Амплитудный Спектр");
            chartColateral.Series.Add("Односторонний Амплитудный Спектр");
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFilePath.Text))
            {
                MessageBox.Show("Некорректный ввод пути аудио файла!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AudioProcessor processor = new AudioProcessor();
            var result = processor.ProcessAudio(textBoxFilePath.Text, out Dictionary<double, double> audioSpecter);
            var freqAmp = processor.ProcessFrequencyAmplitudes(textBoxFilePath.Text);

            if (result != null) 
            {
                processor.BuildChart(freqAmp, chartFrequencyAmplitudes, "Частотный спектр", freqAmp.Count());
                processor.BuildChart(audioSpecter, chartMain, "Аудио спектр", audioSpecter.Count());
                processor.BuildChart(result, chartAmplitude, "Амплитудный Спектр", result.Count());
                processor.BuildChart(result, chartColateral, "Односторонний Амплитудный Спектр", result.Count() / 2);
            }

            Runtime.Dataset.Add(result.Select(d => d.Value).Take(Runtime.CropSize).ToList());

            Runtime.Logger("Информация о звуке добавлена в датасет");
        }

        private void buttonTeach_Click(object sender, EventArgs e)
        {
            Runtime.NeuralNetwork.InitiateTraining();
        }

        private void buttonRecognize_Click(object sender, EventArgs e)
        {
            AudioProcessor processor = new AudioProcessor();
            var result = processor.ProcessAudio(textBoxRecognizePath.Text, out Dictionary<double, double> audioSpecter);

            var recResult = Runtime.NeuralNetwork.Recognize(result.Select(d => d.Value).Take(Runtime.CropSize).ToArray());

            for (int i = 0; i < recResult.Length; i++)
            {
                Runtime.Logger($"Class {i + 1}: {result[i]}");
            }
        }
    }
}
