using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuadrocopterDatasetTrainer.Audio;

namespace QuadrocopterDatasetTrainer
{
    public static class Runtime
    {
        private static ListBox LoggerObject {  get; set; }
        public static List<List<double>> Dataset { get; set; } = new List<List<double>>();
        public static List<AudioProcessor.SoundAnalysisResult> DatasetInfo = new List<AudioProcessor.SoundAnalysisResult>();
        public static NeuralHandler NeuralNetwork { get; set; } = new NeuralHandler();
        public static int CropSize { get; set; } = 128;

        public static void SetLoggerObject(ListBox lo) => LoggerObject = lo;
        public static void Logger(string item) => LoggerObject.Items.Add(item);
    }
}
