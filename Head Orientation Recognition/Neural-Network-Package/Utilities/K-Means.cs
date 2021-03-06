﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_Orientation_Recognition.Neural_Network_Package.Utilities
{
    /// <summary>
    /// Kmeans++ is just for choosing the initial K centroids, after that you normally apply the standard Kmeans.
    /// </summary>
    public class K_Means
    {
        private int K;
        private List<List<double>> Centroids;
        private List<List<double>> X;
        private List<List<int>> Groups;
        //private List<List<double>> Mean;
        private List<double> Variance;

        public List<double> GetVariance
        {
            get { return Variance; }
        }
        public K_Means(ref List<List<double>> Centroids, List<List<double>> X)
        {
            this.X = X;
            this.Centroids = Centroids;
            this.K = Centroids.Count;
            Groups = new List<List<int>>();
            for (int i = 0; i < K; i++)
            {
                Groups.Add(new List<int>());
            }
            Calculate();
            CalculateVariance();
            Centroids = this.Centroids;
        }

        private void Calculate()
        {
            while (true)
            {
                List<int> D = new List<int>();
                for (int i = 0; i < X.Count; i++)
                {
                    double MinD = double.MaxValue;
                    int MinIndex = 0;
                    for (int j = 0; j < K; j++)
                    {
                        double d = 0;
                        for (int k = 0; k < X[i].Count; k++)
                        {
                            d += Math.Pow((Centroids[j][k] - X[i][k]), 2);
                        }
                        d = Math.Sqrt(d);
                        if (d < MinD)
                        {
                            MinD = d;
                            MinIndex = j;
                        }
                    }
                    D.Add(MinIndex);

                }
                List<List<double>> NewCentroids = new List<List<double>>();
                for (int i = 0; i < K; i++)
                {
                    Groups[i].Clear();
                    List<double> Row = new List<double>();
                    int S = X[0].Count;
                    while(S-->0)
                    {
                        Row.Add(0);
                    }
                    int counter = 0;
                    for (int j = 0; j < D.Count; j++)
                    {
                        if (D[j] == i)
                        {
                            for (int col = 0; col < Row.Count; col++)
                            {
                                Row[col] += X[j][col];
                            }
                            Groups[i].Add(j);
                            counter++;
                        }
                    }
                    for (int col = 0; col < Row.Count; col++)
                    {
                        Row[col] /= counter;
                    }
                    NewCentroids.Add(Row);
                }
                if (IsCentroidsHaveChanged(NewCentroids) == false)
                    break;
                FillCentroids(NewCentroids);
            }

        }
        
        //private void CalculateMean()
        //{
        //    Mean = new List<List<double>>();
        //    for(int i=0 ; i<Groups.Count ; i++)
        //    {
        //        List<double> Row = new List<double>();
        //        int S = X[0].Count;
        //        while (S-- > 0)
        //        {
        //            Row.Add(0);
        //        }
        //        for(int j=0 ; j<Groups[i].Count ; j++)
        //        {
        //            int Index = Groups[i][j];
        //            for (int col = 0; col < Row.Count; col++)
        //            {
        //                Row[col] += X[Index][col];
        //            }
        //        }
        //        for (int col = 0; col < Row.Count; col++)
        //        {
        //            Row[col] /= Groups[i].Count;
        //        }
        //        Mean.Add(Row);
        //    }
        //}
        private void CalculateVariance()
        {
            Variance = new List<double>();
            for (int i = 0; i < Groups.Count; i++)
            {
                double V = 0;
                for (int j = 0; j < Groups[i].Count; j++)
                {
                    int Index = Groups[i][j];
                    double Sum = 0;
                    for (int col = 0; col < X[0].Count; col++)
                    {
                        Sum += Math.Pow((X[Index][col] - Centroids[i][col]),2);
                    }
                    V += Math.Sqrt(Sum);
                }
                V /= Groups[i].Count;
                Variance.Add(V);
            }
        }
        private bool IsCentroidsHaveChanged(List<List<double>> NewCentroids)
        {
            for(int i=0 ; i<Centroids.Count ; i++)
            {
                for(int j=0 ; j<Centroids[0].Count ; j++)
                {
                    if (Centroids[i][j] != NewCentroids[i][j])
                        return true;
                }
            }
            return false;
        }
        private void FillCentroids(List<List<double>> NewCentroids)
        {
            for (int i = 0; i < Centroids.Count; i++)
            {
                for (int j = 0; j < Centroids[0].Count; j++)
                {
                    Centroids[i][j] = NewCentroids[i][j];
                }
            }
        }
    }
}
