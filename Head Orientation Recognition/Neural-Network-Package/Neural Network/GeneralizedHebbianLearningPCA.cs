using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_Orientation_Recognition.Neural_Network_Package.Neural_Network
{
    public class GeneralizedHebbianLearningPCA
    {
        private int numberOfFeatures;
        private List<double> input;
        private List<double> output;
        private int numberOfReducedFeatures;
        private List<List<double>> weights;
        private List<List<double>> oldWeights;
        private List<List<double>> trainingSamples, testingSamples;
        private List<List<double>> NewTrainingSamples, NewTestingSamples;
        private double learningRate;

        public List<List<double>> GetNewTrainingSamples
        {
            get { return NewTrainingSamples; }
        }
        public List<List<double>> GetNewTestingSamples
        {
            get { return NewTestingSamples; }
        }
        public GeneralizedHebbianLearningPCA(int numberOfFeatures, int numberOfReducedFeatures, double learningRate, List<List<double>> trainingSamples, List<List<double>> testingSamples)
        {
            this.numberOfFeatures = numberOfFeatures;
            this.numberOfReducedFeatures = numberOfReducedFeatures;
            this.learningRate = learningRate;
            this.trainingSamples = trainingSamples;
            this.testingSamples = testingSamples;

            this.output = new List<double>();
            this.initWeights();
            train();
        }


        /// <summary>
        /// Training the PCA network for the given epochs and training samples to get the input features
        /// </summary>
        /// <param name="epochs">Number of iterations</param>
        /// <param name="trainingSamples">Training Data that holds each sample features</param>
        private void train()
        {
            for (int i = 0; i < 20/*trainingSamples.Count*/; i++)
            {
                oldWeights = new List<List<double>>();

                for (int j = 0; j < this.weights.Count; j++)
                {
                    oldWeights.Add(new List<double>(this.weights[i]));
                }

                this.output = this.featuresReduction(trainingSamples[i]); // for tracing
                this.update(trainingSamples[i]);

                if (this.sameWeights(this.weights, this.oldWeights))
                {
                    break;
                }
            }

            CalcNewTraining();
            CalcNewTesting();
        }

        private void CalcNewTraining()
        {
            NewTrainingSamples = new List<List<double>>();
            for (int i = 0; i < trainingSamples.Count; i++)
            {

                this.output = this.featuresReduction(trainingSamples[i]);
                NewTrainingSamples.Add(this.output);
            }
        }
        private void CalcNewTesting()
        {
            NewTestingSamples = new List<List<double>>();
            for (int i = 0; i < testingSamples.Count; i++)
            {

                this.output = this.featuresReduction(testingSamples[i]);
                NewTestingSamples.Add(this.output);
            }
        }
        /// <summary>
        /// Given the features, the function calculate the resulted features of network
        /// </summary>
        /// <param name="features">Training sample data</param>
        /// <returns></returns>
        private List<double> featuresReduction(List<double> features)
        {
            List<double> output = new List<double>();

            for (int i = 0; i < this.numberOfReducedFeatures; i++)
            {
                output.Add(0.0);
            }

            for (int i = 0; i < this.numberOfReducedFeatures; i++)
            {
                for (int j = 0; j < features.Count; j++)
                {
                    output[i] += features[j] * this.weights[i][j];
                }
            }

            return output;
        }

        /// <summary>
        /// Update the network weights, the weights values could be increased and decreased
        /// The formula = ETA * (y(x - sum(oldweights * yk))
        /// http://en.wikipedia.org/wiki/Generalized_Hebbian_Algorithm
        /// </summary>
        /// <param name="features">Training sample data</param>
        private void update(List<double> features)
        {
            for (int i = 0; i < this.weights.Count; i++)
            {
                for (int j = 0; j < this.weights[i].Count; j++)
                {
                    double sum = this.computeOutput(i, j);
                    double def = features[j] - sum;
                    this.weights[i][j] += this.learningRate * this.output[i] * def;
                }
            }
        }

        /// <summary>
        /// The summation formula
        /// </summary>
        /// <param name="outputIndex">output neuron index</param>
        /// <param name="inputIndex">input index</param>
        /// <returns></returns>
        private double computeOutput(int outputIndex, int inputIndex)
        {
            double sum = 0.0;

            for (int i = 0; i <= outputIndex; i++)
            {
                sum += this.output[i] * this.oldWeights[i][inputIndex];
            }

            return sum;
        }

        /// <summary>
        /// Checking of the the new and old weights have the same values
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        private bool sameWeights(List<List<double>> first, List<List<double>> second)
        {
            for (int i = 0; i < first.Count; i++)
            {
                for (int j = 0; j < first[i].Count; j++)
                {
                    if (first[i][j] != second[i][j])
                        return false;
                }
            }

            return true;
        }

        private void initWeights()
        {
            this.weights = new List<List<double>>();

            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < this.numberOfReducedFeatures; i++)
            {
                this.weights.Add(new List<double>());

                for (int j = 0; j < this.numberOfFeatures; j++)
                {
                    int D = rnd.Next(1, 3);
                    if (D == 2) D = -1;
                    weights[i].Add(rnd.NextDouble()* D);
                    //weights[i].Add(0);
                }
            }
        }
    }
}
