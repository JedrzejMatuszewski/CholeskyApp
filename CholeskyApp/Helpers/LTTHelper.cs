using CholeskyApp.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CholeskyApp.Helpers
{
    public class LTTHelper
    {
        public double[,] MatrixA { get; private set; }
        public double[,] MatrixL { get; private set; }
        public double GenerationTime { get; private set; }

        private int _matrixSize { get; set; }


        public List<ElementP> ListaPomocnicza { get; set; }

        public LTTHelper(int matrixSize)
        {
            ListaPomocnicza = new List<ElementP>();
            _matrixSize = matrixSize;
            MatrixA = GeneratePascalMatrix(_matrixSize);
            CreateMatrixL();
        }


        private void CreateMatrixL()
        {
            var _matrixA = (double[,])MatrixA.Clone();
            var matrixL = new double[_matrixSize, _matrixSize];

            var stopWatch = new Stopwatch();

            stopWatch.Start();

            var nrOperacji = 0;


            for (int i = 0; i < _matrixSize; i++)
            {
                _matrixA[i, i] = Math.Sqrt(_matrixA[i, i]);
                //
                ++nrOperacji;
                ListaPomocnicza.Add(
                    new ElementP
                    {
                        Id = nrOperacji,
                        W_I = i+1,
                        W_J = i+1,//Nie mamy ich, wiec wpisujemy index zewn. petli
                        W_K = i+1,//
                        M1 = $"{i+1} {i+1}",
                        RodzajOperacji = RodzajOperacji.Sqrt
                    }
                );

                for (int j = i + 1; j < _matrixSize; j++)
                {
                    _matrixA[j, i] = _matrixA[j, i] / _matrixA[i, i];
                    //
                    ++nrOperacji;
                    ListaPomocnicza.Add(
                        new ElementP
                        {
                            Id = nrOperacji,
                            W_I = i+1,
                            W_J = j+1,
                            W_K = i+1, //Nie mamy ich, wiec wpisujemy index zewn. petli
                            M1 = $"{i+1} {i+1}",
                            M2 = $"{j+1} {i+1}",
                            RodzajOperacji = RodzajOperacji.Div
                        }
                    );

                }

                for (int j = i + 1; j < _matrixSize; j++)
                {
                    for (int k = i + 1; k <= j; k++)
                    {
                        _matrixA[j, k] = _matrixA[j, k] - _matrixA[j, i] * _matrixA[k, i];
                        //
                        ++nrOperacji;
                        ListaPomocnicza.Add(
                            new ElementP
                            {
                                Id = nrOperacji,
                                W_I = i+1,
                                W_J = j+1,
                                W_K = k+1,
                                M3 = $"{j+1} {i+1}",
                                M4 = $"{k+1} {i+1}",
                                M5 = $"{j+1} {k+1}",
                                RodzajOperacji = RodzajOperacji.MulAndSub                               
                            }
                        );
                    }
                }

            }

            for (int i = 0; i < _matrixSize; i++)
                for (int j = 0; j < _matrixSize; j++)
                    if (i >= j)
                        matrixL[i, j] = _matrixA[i, j];

            stopWatch.Stop();

            //GenerationTime = stopWatch.ElapsedMilliseconds;
            GenerationTime = ( (double)stopWatch.ElapsedTicks / Stopwatch.Frequency) *1000000000;
            MatrixL = matrixL;
        }

        private double[,] GeneratePascalMatrix(int size)
        {
            double[,] m = new double[size, size];
            for (int i = 0; i < size; i++) m[0, i] = m[i, 0] = 1;
            for (int r = 1; r < size; r++)
            {
                for (int c = 1; c < size; c++)
                {
                    m[r, c] = m[r - 1, c] + m[r, c - 1];
                }
            }
            return m;
        }
    }
}
