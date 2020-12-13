using System;
using System.Linq;
using System.Numerics;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputNumbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }

            int leftSum = matrix[0, 0];

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = row; col < matrix.GetLength(1) - 1; col++)
                {
                    leftSum += matrix[row + 1, col + 1];
                    break;
                }
            }

            int rightSum = matrix[0, size - 1];


            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = matrix.GetLength(1) - row - 1; col >= 0; col++)
                {
                    int currentNum = matrix[row + 1, col - 1];
                    rightSum += matrix[row + 1, col - 1];
                    break;
                }
            }

            Console.WriteLine(Math.Abs(leftSum - rightSum));
        }
    }
}
