using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rowsNum = size[0];
            int colsNum = size[1];

            int[,] matrix = new int[rowsNum, colsNum];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentArray = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentArray[col];
                }
            }

            int[,] matrix2x2 = new int[2, 2];

            int maxSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                int currentSum = int.MinValue;

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSum =
                        matrix[row, col] + matrix[row + 1, col]
                        + matrix[row + 1, col + 1] + matrix[row, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;

                        matrix2x2[0, 0] = matrix[row, col];
                        matrix2x2[1, 0] = matrix[row + 1, col];
                        matrix2x2[1, 1] = matrix[row + 1, col + 1];
                        matrix2x2[0, 1] = matrix[row, col + 1];
                    }
                }
            }

            for (int row = 0; row < matrix2x2.GetLength(0); row++)
            {
                for (int col = 0; col < matrix2x2.GetLength(1); col++)
                {
                    Console.Write(matrix2x2[row, col] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
