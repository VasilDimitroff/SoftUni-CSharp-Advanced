using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int forPush = input[0];
            int forPop = input[1];
            int forSearch = input[2];

            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            int minNumber = int.MaxValue;

            for (int i = 0; i < forPush; i++)
            {
                stack.Push(inputNumbers[i]);
            }

            for (int i = 0; i < forPop; i++)
            {
                stack.Pop();
            }

            int iterations = stack.Count;

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < iterations; i++)
            {
                int currentNumber = stack.Pop();

                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }

                if (currentNumber == forSearch)
                {
                    Console.WriteLine("true");
                    return;
                }

            }

            Console.WriteLine(minNumber);
        }
    }
}
