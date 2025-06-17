using NAudio.Gui;
using NAudio.Wave;
using QuadrocopterDatasetTrainer.Audio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

            var reader = AudioProcessor.GetReader(textBoxFilePath.Text);
            waveViewer.WaveStream = reader;
            waveViewer.BackColor = Color.DarkCyan;
            waveViewer.ForeColor = Color.DarkRed;
            waveViewer.Refresh();

            if (result != null) 
            {
                processor.BuildChart(freqAmp, chartFrequencyAmplitudes, "Частотный спектр", freqAmp.Count());
                processor.BuildChart(audioSpecter, chartMain, "Аудио спектр", audioSpecter.Count());
                processor.BuildChart(result, chartAmplitude, "Амплитудный Спектр", result.Count());
                processor.BuildChart(result, chartColateral, "Односторонний Амплитудный Спектр", result.Count() / 2);
            }

            var datasetResult = processor.AnalyzeSoundFile(textBoxFilePath.Text);
            Runtime.Dataset.Add(result.Select(d => d.Value).Take(Runtime.CropSize).ToList());
            Runtime.DatasetInfo.Add(datasetResult);

            tabControlMain.TabPages[1].Text = $"Анализ (файл \"{Path.GetFileName(textBoxFilePath.Text)}\")";

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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 2) 
            {
                dataGridViewDatasetInfo.Rows.Clear();
                foreach (var datasetInfo in Runtime.DatasetInfo)
                    dataGridViewDatasetInfo.Rows.Add(datasetInfo.FileName, $"{datasetInfo.MinFrequencyHz}-{datasetInfo.MaxFrequencyHz}Гц", datasetInfo.NoiseLevelDb, datasetInfo.SignalPowerWatt, datasetInfo.SignalToNoiseRatioDb, $"{datasetInfo.SuitabilityLevelPercent} ({datasetInfo.SuitabilityLabel})");
            }
        }

        private void textBoxFilePath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                    textBoxFilePath.Text = files[0];
            }
        }

        private void textBoxFilePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
