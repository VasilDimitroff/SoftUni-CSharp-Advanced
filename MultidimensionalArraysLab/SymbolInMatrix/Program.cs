using System;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] charArr = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = charArr[col];
                }
            }

            char input = char.Parse(Console.ReadLine());

            int rowIndex = -1;
            int colIndex = -1;
            bool isMatch = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == input)
                    {
                        rowIndex = row;
                        colIndex = col;
                        isMatch = true;
                        break;
                    }
                }


                if (isMatch)
                {
                    break;
                }
            }

            if (rowIndex > -1 && colIndex > -1)
            {
                Console.WriteLine($"({rowIndex}, {colIndex})");
            }

            else
            {
                Console.WriteLine($"{input} does not occur in the matrix");
            }

        }
    }
}
