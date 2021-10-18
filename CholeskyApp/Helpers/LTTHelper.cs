using System;
using System.Diagnostics;

namespace CholeskyApp.Helpers
{
    public class LTTHelper
    {
        public double[,] MatrixA { get; private set; }
        public double[,] MatrixL { get; private set; }
        public long GenerationTime { get; private set; }

        private int _matrixSize { get; set; }

        public LTTHelper(int matrixSize)
        {
            _matrixSize = matrixSize;
            MatrixA = GeneratePascalMatrix(_matrixSize);
            CreateMatrixL();
        }


        private void CreateMatrixL()
        {
            var matrixL = new double[_matrixSize, _matrixSize];
            var stopWatch = new Stopwatch();
            double sum;

            stopWatch.Start();
            for (int s = 0; s < _matrixSize; s++)
            {
                for (int i = s; i < _matrixSize; i++)
                {
                    sum = 0.0;
                    for (int j = 0; j < s; j++)
                        sum += matrixL[i, j] * matrixL[s, j];

                    matrixL[i, s] = MatrixA[i, s] - sum;

                    if (s == i)
                        matrixL[i, s] = Math.Sqrt((matrixL[i, s]));
                    else
                        matrixL[i, s] = matrixL[i, s] / matrixL[s, s];
                }
            }
            stopWatch.Stop();

            GenerationTime = stopWatch.ElapsedMilliseconds;
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
