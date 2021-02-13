using System;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = bounds[0];
            int end = bounds[1];

            string command = Console.ReadLine();

            Predicate<int> isEven = x => x % 2 == 0;
            PrintNumbers(command, isEven, start, end);
        }

        static void PrintNumbers(string command, Predicate<int> predicate, int start, int end)
        {
            if (command == "odd")
            {
                for (int i = start; i <= end; i++)
                {
                    if (!predicate(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            else if (command == "even")
            {
                for (int i = start; i <= end; i++)
                {
                    if (predicate(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
