using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentNumbers[col];
                }
            }

            int maxSum = int.MinValue;
            int currentSum = 0;
            int maxIndexRow = -1;
            int maxIndexCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {


                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    currentSum = 0;
                    /*
                          0. 1. 2.  3. 4.
                       0. 1  5  5   2  4
                       1. 2  1  4  14  3
                       2. 3  7  11  2  8
                       3. 4  8  12 16  4
                    */
                    currentSum =
                        matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxIndexRow = row;
                        maxIndexCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxIndexRow; row < maxIndexRow + 3; row++)
            {
                for (int col = maxIndexCol; col < maxIndexCol + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
