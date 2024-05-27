using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Neuro;
using Accord.Neuro.Learning;
using Accord.Neuro.ActivationFunctions;
using Accord.Neuro.Networks;

namespace QuadrocopterDatasetTrainer
{
    public class NeuralHandler
    {
        private ActivationNetwork network;

        private ActivationNetwork CreateNetwork(int inputCount, int hiddenNeurons, int outputCount)
        {
            var function = new SigmoidFunction();
            var network = new ActivationNetwork(function, inputCount, hiddenNeurons, outputCount);
            new NguyenWidrow(network).Randomize();
            return network;
        }

        private void TrainNetwork(double[][] inputs, double[][] outputs)
        {
            Runtime.Logger("Начало процесса обучения");
            var teacher = new BackPropagationLearning(network)
            {
                LearningRate = 0.1,
                Momentum = 0.0
            };

            int epoch = 0;
            double error;
            do
            {
                error = teacher.RunEpoch(inputs, outputs);
                Runtime.Logger($"Эпоха {epoch++}, Уровень ошибки: {error}");
            } while (error > 0.01);
        }

        public double[] Recognize(double[] input)
        {
            return network.Compute(input);
        }

        public void InitiateTraining() 
        {
            double[][] inputs = Runtime.Dataset.Select(d => d.Take(Runtime.CropSize).ToArray()).ToArray();
            
            // Мока
            double[][] outputs = new double[][]
            {
            new double[] { 1, 0 }, // Квадрик 1
            new double[] { 0, 1 }  // Квадрик 2
            };

            int inputCount = inputs[0].Length;
            int hiddenNeurons = 10;
            int outputCount = outputs[0].Length;

            network = CreateNetwork(inputCount, hiddenNeurons, outputCount);

            TrainNetwork(inputs, outputs);

            Runtime.Logger("Завершен процесс обучения");
        }
    }
}
