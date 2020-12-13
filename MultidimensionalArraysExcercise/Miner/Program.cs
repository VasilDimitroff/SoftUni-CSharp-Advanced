using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ReadMatrix(matrix);

            //find coal numbers
            // find start point
            // find end point
            int coalCount = 0;

            int startRow = -1;
            int startCol = -1;

            int endRow = -1;
            int endCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'c')
                    {
                        coalCount++;
                    }

                    else if (matrix[row, col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }

                    else if (matrix[row, col] == 'e')
                    {
                        endRow = row;
                        endCol = col;
                    }
                }
            }


            for (int i = 0; i < input.Length; i++)
            {
                string command = input[i];

                if (command == "up")
                {
                    if (startRow - 1 >= 0)
                    {
                        startRow -= 1;
                    }

                    else
                    {
                        continue;
                    }

                    if (matrix[startRow, startCol] == 'c')
                    {
                        coalCount--;
                        matrix[startRow, startCol] = '*';
                    }

                    if (coalCount <= 0)
                    {
                        Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                        break;
                    }

                    if (matrix[startRow, startCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({startRow}, {startCol})");
                        break;
                    }
                }

                else if (command == "down")
                {
                    if (startRow + 1 < matrix.GetLength(0))
                    {
                        startRow += 1;
                    }

                    else
                    {
                        continue;
                    }

                    if (matrix[startRow, startCol] == 'c')
                    {
                        coalCount--;
                        matrix[startRow, startCol] = '*';
                    }

                    if (coalCount <= 0)
                    {
                        Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                        break;
                    }

                    if (matrix[startRow, startCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({startRow}, {startCol})");
                        break;
                    }
                }

                else if (command == "right")
                {
                    if (startCol + 1 < matrix.GetLength(0))
                    {
                        startCol += 1;
                    }

                    else
                    {
                        continue;
                    }

                    if (matrix[startRow, startCol] == 'c')
                    {
                        coalCount--;
                        matrix[startRow, startCol] = '*';
                    }

                    if (coalCount <= 0)
                    {
                        Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                        break;
                    }

                    if (matrix[startRow, startCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({startRow}, {startCol})");
                        break;
                    }
                }

                else if (command == "left")
                {
                    if (startCol - 1 >= 0)
                    {
                        startCol -= 1;
                    }

                    else
                    {
                        continue;
                    }

                    if (matrix[startRow, startCol] == 'c')
                    {
                        coalCount--;
                        matrix[startRow, startCol] = '*';
                    }

                    if (coalCount <= 0)
                    {
                        Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                        break;
                    }

                    if (matrix[startRow, startCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({startRow}, {startCol})");
                        break;
                    }
                }

                if (i == input.Length - 1 && coalCount > 0)
                {
                    Console.WriteLine($"{coalCount} coals left. ({startRow}, {startCol})");
                    break;
                }

            }
        }

        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}
