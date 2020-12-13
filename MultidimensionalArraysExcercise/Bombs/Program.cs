using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            ReadMatrix(matrix);

            int[] input = Console.ReadLine().Split(new string[] { " ", ", ", "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i = i + 2)
            {
                // 1,2  3,4   5,6
                int row = input[i];
                int col = input[i + 1];

                if (matrix[row, col] > 0)
                {
                    if (row - 1 >= 0 && col - 1 >= 0)
                    {
                        if (matrix[row - 1, col - 1] > 0)
                        {
                            matrix[row - 1, col - 1] -= matrix[row, col];
                        }
                    }

                    if (row - 1 >= 0)
                    {
                        if (matrix[row - 1, col] > 0)
                        {
                            matrix[row - 1, col] -= matrix[row, col];
                        }
                    }

                    if (row - 1 >= 0 && col + 1 < matrix.GetLength(1))
                    {
                        if (matrix[row - 1, col + 1] > 0)
                        {
                            matrix[row - 1, col + 1] -= matrix[row, col];
                        }
                    }

                    if (col - 1 >= 0)
                    {
                        if (matrix[row, col - 1] > 0)
                        {
                            matrix[row, col - 1] -= matrix[row, col];
                        }
                    }

                    if (col + 1 < matrix.GetLength(1))
                    {
                        if (matrix[row, col + 1] > 0)
                        {
                            matrix[row, col + 1] -= matrix[row, col];
                        }
                    }

                    if (row + 1 < matrix.GetLength(0) && col - 1 >= 0)
                    {
                        if (matrix[row + 1, col - 1] > 0)
                        {
                            matrix[row + 1, col - 1] -= matrix[row, col];
                        }
                    }

                    if (row + 1 < matrix.GetLength(0))
                    {
                        if (matrix[row + 1, col] > 0)
                        {
                            matrix[row + 1, col] -= matrix[row, col];
                        }
                    }

                    if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1))
                    {
                        if (matrix[row + 1, col + 1] > 0)
                        {
                            matrix[row + 1, col + 1] -= matrix[row, col];
                        }
                    }

                    matrix[row, col] = 0;
                }
            }

            int activeCells = 0;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        activeCells++;
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {activeCells}");
            Console.WriteLine($"Sum: {sum}");

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}
