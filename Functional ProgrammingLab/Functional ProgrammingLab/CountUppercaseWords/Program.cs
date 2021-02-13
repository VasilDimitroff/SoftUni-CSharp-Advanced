using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOnly = Console.ReadLine();

            if (inputOnly.Length > 0)
            {
                string[] input = inputOnly.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Func<string, bool> startWithUpper = x => (Char.IsUpper(x[0]));

                for (int i = 0; i < input.Length; i++)
                {
                    if (startWithUpper(input[i]))
                    {
                        Console.WriteLine(input[i]);
                    }
                }
            }
        }
    }
}
