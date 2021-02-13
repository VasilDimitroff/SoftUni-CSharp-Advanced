using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var numbers = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!numbers.ContainsKey(input[i]))
                {
                    numbers.Add(input[i], 0);
                }

                numbers[input[i]]++;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}