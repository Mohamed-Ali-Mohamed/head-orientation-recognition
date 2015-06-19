using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetworkPackage;
using Head_Orientation_Recognition.Neural_Network_Package.Neural_Network;
using System.Diagnostics;
using Head_Orientation_Recognition.Neural_Network_Package.Utilities;

namespace Head_Orientation_Recognition
{
    public partial class MainForm : Form
    {
        Preprocessing.LoadDataset DataSet;
		FeedforwardNeuralNetwrok neuralNetwork;
        GeneralizedHebbianLearningPCA G_PCA;
        RBF _RBF;
        private int TestingNoInClass = 30;
        private List<List<double>> trainingSamples;
        private List<List<double>> trainingLabels;
        private List<List<double>> testSamples;
        private List<List<double>> testLabels;
        private List<List<double>> Centroids;
        private string trainingSamplesAfterPCA = "trainingSamplesAfterPCA.txt",
            trainingLabelsAfterPCA="trainingLabelsAfterPCA.txt",
            testSamplesAfterPCA = "testSamplesAfterPCA.txt",
            testLabelsAfterPCA = "testLabelsAfterPCA.txt";
        public MainForm()
        {
            InitializeComponent();
            trainingSamples = new List<List<double>>();
            trainingLabels = new List<List<double>>();
            testSamples = new List<List<double>>();
            testLabels = new List<List<double>>();
        }

        #region GUI
        private void LoadMainDataSetButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            this.DataSet = new Preprocessing.LoadDataset(System.IO.Directory.GetCurrentDirectory());

            this.Enabled = true;

            LoadMainDataSetButton.Enabled = false;
            PCA_TrainButton.Enabled = true;

            RBTrainButton.Enabled = true;
            MessageBox.Show("Done");
        }
        private void LoadDataSetButton_Click(object sender, EventArgs e)
        {
            LoadDataSetButton.Enabled = false;
            trainingLabels = LoadFromFile(trainingLabelsAfterPCA);
            trainingSamples = LoadFromFile(trainingSamplesAfterPCA);

            testLabels = LoadFromFile(testLabelsAfterPCA);
            testSamples = LoadFromFile(testSamplesAfterPCA);

            BackpropagationTrainButton.Enabled = true;
            MessageBox.Show("Done");
        }
        private void MLNumOfLayersUpDown_ValueChanged(object sender, EventArgs e)
        {
            int N = (int)MLNumOfLayersUpDown.Value;
            N -= 2;
            NeuronsInHLayers.RowCount = N;
            for (int i = 0; i < N; i++)
            {
                NeuronsInHLayers[0, i].Value = (i + 1).ToString();
            }
        }
        private void TrainButton_Click(object sender, EventArgs e)
        {
            Train();
            MessageBox.Show("Done");
        }
        private void BackpropagationTrainButton_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            //
            Train();
            //
            watch.Stop();
            var elapsed = watch.Elapsed.TotalSeconds;
            TimesOfMLP.Text = elapsed.ToString() + " s";
            //
            BackpropagationTestButton.Enabled = true;
            BackpropagationTrainButton.Enabled = true;

            MessageBox.Show("Done");
        }
        private void PCA_TrainButton_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            //
            PCA();
            //
            watch.Stop();
            var elapsed = watch.Elapsed.TotalSeconds;

            TimesOfPCA.Text = elapsed.ToString() + " s";
            MessageBox.Show("Done");
        }
        private void BackpropagationTestButton_Click(object sender, EventArgs e)
        {
            int[,] matrix = Test();
            this.setColumns(new string[] { "1", "2", "3", "reject" }, MPConfusionMatrix);
            this.setRows(new string[] { "1", "2", "3" }, MPConfusionMatrix);
            this.setConfusionMatrix(matrix, MPConfusionMatrix, MPOverallAccuracyBox);
            MessageBox.Show("Done!");

        }

        private void RBTrainButton_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            //
            RB_Train();
            //
            watch.Stop();
            var elapsed = watch.Elapsed.TotalSeconds;
            TimesOfRBF.Text = elapsed.ToString() + " s";
            //
            RBTestButton.Enabled = true;

            MessageBox.Show("Done!");
        }
        private void RBTestButton_Click(object sender, EventArgs e)
        {
            int[,] matrix = RB_Test();
            this.setColumns(new string[] { "1", "2", "3", "reject" }, RBConfusionMatrix);
            this.setRows(new string[] { "1", "2", "3" }, RBConfusionMatrix);
            this.setConfusionMatrix(matrix, RBConfusionMatrix, RBOverallAccuracyBox);
            MessageBox.Show("Done!");
        }
        #endregion

        #region Confusion Matrix
        private void setColumns(string[] names, DataGridView Grid)
        {
            Grid.ColumnCount = names.Length;

            for (int i = 0; i < names.Length; i++)
            {
                Grid.Columns[i].Name = names[i];
            }
        }
        private void setRows(string[] names, DataGridView Grid)
        {
            Grid.RowCount = names.Length;

            for (int i = 0; i < names.Length; i++)
            {
                Grid.Rows[i].HeaderCell.Value = names[i];
            }
        }
        private void setConfusionMatrix(int[,] matrix, DataGridView Grid, TextBox AccuracyBox)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int total = 0;
            int overAllAccuracy = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == j)
                        overAllAccuracy += matrix[i, j];
                    total += matrix[i, j];
                    Grid.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }
            try
            {
                AccuracyBox.Text = (((float)overAllAccuracy / total) * 100.0).ToString().Substring(0, 5) + " %";
            }
            catch
            {
                AccuracyBox.Text = (((float)overAllAccuracy / total) * 100.0).ToString() + "%";
            }

        }
        #endregion


        #region Train & Test
        
        private void PCA()
        {
            double learningRate = double.Parse(PCA_LearningRateUpDown.Value.ToString());

            this.getData(ref trainingSamples, ref trainingLabels, true);
            this.getData(ref testSamples, ref testLabels, false);

            List<List<double>> all = new List<List<double>>();

            all.AddRange(this.trainingSamples);
            all.AddRange(this.testSamples);

            Normalization normaliz = new Normalization(all);

            for (int i = 0; i < this.trainingSamples.Count; ++i)
            {
                this.trainingSamples[i] = normaliz.normalizeByStdDev(this.trainingSamples[i]);
            }
            for (int i = 0; i < this.testSamples.Count; ++i)
            {
                this.testSamples[i] = normaliz.normalizeByStdDev(this.testSamples[i]);
            }

            G_PCA = new GeneralizedHebbianLearningPCA(trainingSamples[0].Count, 16 * 16, learningRate, trainingSamples, testSamples);
            trainingSamples = G_PCA.GetNewTrainingSamples;
            testSamples = G_PCA.GetNewTestingSamples;
           

            ////trainingSamplesAfterPCA
            SaveInFile(trainingSamples, trainingSamplesAfterPCA);
            ////trainingLabelsAfterPCA
            SaveInFile(trainingLabels, trainingLabelsAfterPCA);
            ////testSamplesAfterPCA
            SaveInFile(testSamples, testSamplesAfterPCA);
            ////testLabelsAfterPCA
            SaveInFile(testLabels, testLabelsAfterPCA);
        }
       
       
        
        private void Train()
		{

            int numOfLayers = (int)MLNumOfLayersUpDown.Value;
            double learningRate = (double)MPLearningRateUpDown.Value;
			List<int> numOfNeuronsPerLayer = new List<int> ();

            int numOfEpocks = (int)MLNumOfEpocksUpDown.Value;
			LearningAlgorithm backpropagation = new Backpropagation ();

           for (int i = 0; i < numOfLayers; ++i)
                numOfNeuronsPerLayer.Add((i == 0) ? trainingSamples[0].Count : (i == numOfLayers - 1) ? 3 : int.Parse(NeuronsInHLayers[1,i-1].Value.ToString()));


			this.neuralNetwork = new FeedforwardNeuralNetwrok (numOfLayers);
			this.neuralNetwork.setNetwork (numOfNeuronsPerLayer);
			for (int i = 1; i < numOfLayers; ++i)
				this.neuralNetwork.setLayer (i, new SigmoidFunction ());
            
            

			for (int i = 0; i < numOfEpocks; ++i)
				this.neuralNetwork.train (trainingSamples, trainingLabels, learningRate, backpropagation);
		}
		private int[,] Test()
		{
			int[,] matrix = new int[3, 4];
            
			for (int i = 0; i < testSamples.Count; ++i) 
            {
				List<double> actualOutput = this.neuralNetwork.feedforward (testSamples [i]);
				int actualClass = this.checkClass (actualOutput);
                int desiredClass = i / TestingNoInClass;

				if (actualClass == -1)
					actualClass = 3;
				matrix [desiredClass, actualClass]++;
			}

			return matrix;
		}

        private void RB_Train()
        {
            int K = (int)RBNumOfKUpDown.Value;
            int numOfEpocks = int.Parse(RBNumOfEpocksUpDown.Value.ToString());
            double learningRate = (double)RBLearningRateUpDown.Value;
            double maxError = (double)RB_MaxErrorNumericUpDown.Value;

            this.getData(ref trainingSamples, ref trainingLabels, true);
            this.getData(ref testSamples, ref testLabels, false);

            _RBF = new RBF(K, numOfEpocks, learningRate, maxError, trainingSamples, trainingLabels, testSamples, testLabels);
            _RBF.Train();
        }
        private int[,] RB_Test()
        {
            int[,] matrix = _RBF.Test();
            return matrix;
        }

        #endregion

        #region Load Data
        private void getData(ref List<List<double>> dataSamples, ref List<List<double>> dataLabels, bool train)
		{
            dataSamples = new List<List<double>>();
            dataLabels = new List<List<double>>();
			byte[,,] data = (train) ? this.DataSet.GetTrainingInput () : this.DataSet.GetTestingInput ();
			
            
            int numOfClasses = data.GetLength (0);
			int numOfSamples = data.GetLength (1);
			int sizeOfSample = data.GetLength (2);

			List<double> frontClassOutput = new List<double> ();
			frontClassOutput.Add (1);frontClassOutput.Add (0);frontClassOutput.Add (0);

			List<double> leftClassOutput = new List<double> ();
			leftClassOutput.Add (0);leftClassOutput.Add (1);leftClassOutput.Add (0);

			List<double> rightClassOutput = new List<double> ();
			rightClassOutput.Add (0);rightClassOutput.Add (0);rightClassOutput.Add (1);


			for (int classNum = 0; classNum < numOfClasses; classNum++) {
				for (int sampleNum = 0; sampleNum < numOfSamples; sampleNum++) {
					List<double> sample = new List<double> ();
					for (int featuerNum = 0; featuerNum < sizeOfSample; featuerNum++) {
						sample.Add ((double)data [classNum, sampleNum, featuerNum]);
					}
					dataSamples.Add (sample);
					dataLabels.Add ((classNum == 0) ? frontClassOutput : (classNum == 1) ? leftClassOutput : rightClassOutput);
				}
			}
		}
		private int checkClass(List<double> actualOutput)
		{
			int index = 0;
			double max = 0;
			for (int i = 0; i < actualOutput.Count; ++i) {
				if (actualOutput [i] > max) {
					max = actualOutput [i];
					index = i;
				}
			}

			int counter = 0;
			for (int i = 0; i < actualOutput.Count; ++i) {
				if (max == actualOutput [i]) {
					counter++;
				} else
					break;
			}
			if (counter == actualOutput.Count)
				return -1;
			return index;
        }

        #endregion

        #region File
        private void SaveInFile(List<List<double>> Input, string FileName)
        {
            string[] Lines = new string[Input.Count];
            for (int i = 0; i < Input.Count; i++)
            {
                string line = "";
                for (int j = 0; j < Input[i].Count; j++)
                {
                    line += Input[i][j].ToString();
                    if(j < Input[i].Count -1)
                    {
                        line += " ";
                    }
                }
                Lines[i] = line;
            }
            System.IO.File.WriteAllLines(FileName, Lines);

        }

        private List<List<double>> LoadFromFile(string FileName)
        {
            List<List<double>> Output = new List<List<double>>();
            string[] Lines = System.IO.File.ReadAllLines(FileName); ;
            for (int i = 0; i < Lines.Length; i++)
            {
                string[] line = Lines[i].Split(' ');
                List<double> FinalLine = new List<double>(); 
                for (int j = 0; j < line.Length; j++)
                {
                    FinalLine.Add(double.Parse(line[j]));
                }
                Output.Add(FinalLine);
            }
            return Output;
        }

        #endregion

        












    }
}
