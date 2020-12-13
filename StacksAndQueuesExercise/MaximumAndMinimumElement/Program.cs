using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberQueries = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            for (int i = 0; i < numberQueries; i++)
            {
                int[] inputNumbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int command = inputNumbers[0];

                if (command == 1)
                {
                    int numberToPush = inputNumbers[1];
                    stack.Push(numberToPush);
                }

                else if (command == 2)
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }
                }

                else if (command == 3)
                {
                    //maximum
                    if (stack.Count != 0)
                    {
                        Stack<int> checkMaxStack = new Stack<int>(stack);
                        int interations = checkMaxStack.Count;

                        for (int j = 0; j < interations; j++)
                        {
                            int currentNumber = checkMaxStack.Pop();

                            if (currentNumber > maxNumber)
                            {
                                maxNumber = currentNumber;
                            }
                        }

                        Console.WriteLine(maxNumber);
                    }
                }

                else if (command == 4)
                {

                    if (stack.Count != 0)
                    {
                        //minimum
                        Stack<int> checkMinStack = new Stack<int>(stack);
                        int interations = checkMinStack.Count;

                        for (int j = 0; j < interations; j++)
                        {
                            int currentNumber = checkMinStack.Pop();

                            if (currentNumber < minNumber)
                            {
                                minNumber = currentNumber;
                            }
                        }

                        Console.WriteLine(minNumber);
                    }
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
