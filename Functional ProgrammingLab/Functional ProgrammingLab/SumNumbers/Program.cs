using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int sum = numbers.Sum();

            Console.WriteLine(numbers.Length);
            Console.WriteLine(sum);
        }
    }
}
