using System;
using System.Linq;

namespace MatrixShuffling
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

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] currentInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentInput[col];
                }
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                //swap 0 0 1 1
                if (!input.StartsWith("swap"))
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                else
                {
                    string[] inputData = input.Split(" ");

                    if (inputData.Length != 5)
                    {
                        Console.WriteLine("Invalid input!");
                        input = Console.ReadLine();
                        continue;
                    }

                    else
                    {
                        string command = inputData[0];
                        int row1 = int.Parse(inputData[1]);
                        int col1 = int.Parse(inputData[2]);
                        int row2 = int.Parse(inputData[3]);
                        int col2 = int.Parse(inputData[4]);


                        if (command == "swap")
                        {
                            if (
                                row1 >= 0 && row1 < matrix.GetLength(0) && col1 >= 0 && col1 < matrix.GetLength(1)
                                && row2 >= 0 && row2 < matrix.GetLength(0) && col2 >= 0 && col2 < matrix.GetLength(1)
                                )
                            {
                                string tempValue1 = matrix[row1, col1];
                                string tempValue2 = matrix[row2, col2];

                                matrix[row1, col1] = tempValue2;
                                matrix[row2, col2] = tempValue1;

                                for (int i = 0; i < matrix.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matrix.GetLength(1); j++)
                                    {
                                        Console.Write(matrix[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                            }

                            else
                            {
                                Console.WriteLine("Invalid input!");
                            }
                        }

                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
