using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                //Add 0 0 5
                //Subtract 1 1 2

                string[] info = command.Split();
                string cmd = info[0];
                int row = int.Parse(info[1]);
                int col = int.Parse(info[2]);
                int value = int.Parse(info[3]);

                if (cmd == "Add")
                {
                    if (ValidateIndex(row, col, matrix))
                    {
                        matrix[row, col] += value;
                    }

                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                else if (cmd == "Subtract")
                {
                    if (ValidateIndex(row, col, matrix))
                    {
                        matrix[row, col] -= value;
                    }

                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                command = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        static bool ValidateIndex(int row, int col, int[,] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }

            return false;
        }

        static void PrintMatrix(int[,] matrix)
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
    }
}
