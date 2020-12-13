using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int forEnqueue = input[0];
            int forDequeue = input[1];
            int forSearch = input[2];

            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            int minNumber = int.MaxValue;

            for (int i = 0; i < forEnqueue; i++)
            {
                queue.Enqueue(inputNumbers[i]);
            }

            for (int i = 0; i < forDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int iterations = queue.Count;

            for (int i = 0; i < iterations; i++)
            {
                int currentNumber = queue.Dequeue();

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
