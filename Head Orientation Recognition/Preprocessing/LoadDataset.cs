using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_Orientation_Recognition.Preprocessing
{
    public class LoadDataset
    {
        private string TrainingDataFrontPath, TrainingDataLeftPath, TrainingDataRightPath;
        private string TestingDataFrontPath, TestingDataLeftPath, TestingDataRightPath;

        private int ClassNo = 3;
        private int TrainingNoInClass = 50;
        private int TestingNoInClass = 30;
        private int SamplesWidth = 50;
        private int SamplesHeight = 50;

        private byte[,,] TrainingInput;
        private byte[,,] TestingInput;
        public LoadDataset(string DataSetPath)
        {
            string DataPath = DataSetPath + "/Head Orientation Data set/";
            TrainingDataFrontPath = DataPath + "Training/Data_Front/";
            TrainingDataLeftPath = DataPath + "Training/Data_Left/";
            TrainingDataRightPath = DataPath + "Training/Data_Right/";

            TestingDataFrontPath = DataPath + "Testing/Test_Front/";
            TestingDataLeftPath = DataPath + "Testing/Test_Left/";
            TestingDataRightPath = DataPath + "Testing/Test_Right/";

            TrainingInput = new byte[ClassNo, TrainingNoInClass, SamplesHeight * SamplesWidth];
            TestingInput = new byte[ClassNo, TestingNoInClass, SamplesHeight * SamplesWidth];

            LoadTraining();
            LoadTesting();
        }

        public byte[,,] GetTrainingInput()
        {
            return TrainingInput;
        }
        public byte[, ,] GetTestingInput()
        {
            return TestingInput;
        }
        private byte[] NNInput(byte[,] ImageBuffer)
        {
            int Height = ImageBuffer.GetLength(1);
            int Width = ImageBuffer.GetLength(0);
            byte[] Buffer = new byte[Width * Height];
            int Index = 0;
            for (int r = 0; r < Height; r++)
            {
                for(int c=0 ; c<Width ; c++)
                {
                    Buffer[Index++] = ImageBuffer[r, c];
                }
            }

            return Buffer;
        }

        private void FillTrainingInput(int ClassNumber, int ImageNumber, byte[] Buffer)
        {
            for (int j = 0; j < Buffer.Length; j++)
            {
                TrainingInput[ClassNumber -1, ImageNumber - 1, j] = Buffer[j];
            }
        }

        private void FillTestingInput(int ClassNumber, int ImageNumber, byte[] Buffer)
        {
            for (int j = 0; j < Buffer.Length; j++)
            {
                TestingInput[ClassNumber - 1, ImageNumber - 1, j] = Buffer[j];
            }
        }

        private void LoadTraining()
        {
            Image OneImage = new Image();
            byte[] Buffer;
            for (int i = 1; i <= TrainingNoInClass; i++)
            {
                //Class #1
                Buffer = NNInput( OneImage.GetImage(TrainingDataFrontPath + "head (" + i.ToString() + ").png") );
                FillTrainingInput(1, i, Buffer);
                //Class #2
                Buffer = NNInput(OneImage.GetImage(TrainingDataLeftPath + "head (" + i.ToString() + ").png"));
                FillTrainingInput(2, i, Buffer);
                //Class #3
                Buffer = NNInput(OneImage.GetImage(TrainingDataRightPath + "head (" + i.ToString() + ").png"));
                FillTrainingInput(3, i, Buffer);
            }
        }

        private void LoadTesting()
        {
            Image OneImage = new Image();
            byte[] Buffer;
            for (int i = 1; i <= TestingNoInClass; i++)
            {
                //Class #1
                Buffer = NNInput(OneImage.GetImage(TestingDataFrontPath + "head (" + i.ToString() + ").png"));
                FillTestingInput(1, i, Buffer);
                //Class #2
                Buffer = NNInput(OneImage.GetImage(TestingDataLeftPath + "head (" + i.ToString() + ").png"));
                FillTestingInput(2, i, Buffer);
                //Class #3
                Buffer = NNInput(OneImage.GetImage(TestingDataRightPath + "head (" + i.ToString() + ").png"));
                FillTestingInput(3, i, Buffer);
            }
        }
    }
}
