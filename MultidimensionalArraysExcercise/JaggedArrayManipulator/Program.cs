using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[rows][];

            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggedArray[row] = new double[inputArray.Length];

                for (int col = 0; col < inputArray.Length; col++)
                {

                    jaggedArray[row][col] = inputArray[col];
                }
            }

            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {

                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                    }

                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] *= 2;
                    }
                }

                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }

                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splitted = input.Split();

                string command = splitted[0];
                int row = int.Parse(splitted[1]);
                int column = int.Parse(splitted[2]);
                double value = int.Parse(splitted[3]);

                if (command == "Add")
                {
                    if (ValidateIndices(row, column, jaggedArray))
                    {
                        jaggedArray[row][column] += value;
                    }
                }

                else if (command == "Subtract")
                {
                    if (ValidateIndices(row, column, jaggedArray))
                    {
                        jaggedArray[row][column] -= value;
                    }
                }

                input = Console.ReadLine();
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
        private static bool ValidateIndices(int row, int col, double[][] jaggedArray)
        {
            if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
            {
                return true;
            }

            return false;
        }
    }
}
