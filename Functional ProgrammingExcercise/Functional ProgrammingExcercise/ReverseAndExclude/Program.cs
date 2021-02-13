using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Func<int[], int[]> filterNumbers = x => x.Where(num => num % n != 0).ToArray();

            Console.WriteLine(String.Join(" ", filterNumbers(numbers)));
        }
    }
}
