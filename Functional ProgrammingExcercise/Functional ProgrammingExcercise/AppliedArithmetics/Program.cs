using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int[]> add = n => n.Select(x => x + 1).ToArray();
            Func<int[], int[]> multiply = n => n.Select(x => x * 2).ToArray();
            Func<int[], int[]> subtract = n => n.Select(x => x - 1).ToArray();
            Func<int[], string> print = array => String.Join(" ", array);

            string cmd = Console.ReadLine();

            while (cmd != "end")
            {
                if (cmd == "add")
                {
                    numbers = add(numbers);
                }
                else if (cmd == "multiply")
                {
                    numbers = multiply(numbers);
                }

                else if (cmd == "subtract")
                {
                    numbers = subtract(numbers);
                }

                else if (cmd == "print")
                {
                    Console.WriteLine(print(numbers));
                }

                cmd = Console.ReadLine();
            }
        }
    }
}
