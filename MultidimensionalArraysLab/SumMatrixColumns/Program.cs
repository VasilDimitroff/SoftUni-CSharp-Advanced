using System;
using System.Linq;
using System.Numerics;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixInfo = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = matrixInfo[0];
            int cols = matrixInfo[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            /*
                7 1 3 3 2 1
                1 3 9 8 5 6
                4 6 7 9 1 0
           */

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int[] sumCols = new int[matrix.GetLength(1)];

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumCols[col] += matrix[row, col];
                }

                Console.WriteLine(sumCols.Sum());
            }
        }
    }
}
