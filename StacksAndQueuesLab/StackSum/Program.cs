using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine().ToLower();
            string[] splitted = command.Split();
            Stack<int> numbers = new Stack<int>(input);

            while (command != "end")
            {
                if (splitted[0] == "add")
                {
                    int firstNumber = int.Parse(splitted[1]);
                    int secondNumber = int.Parse(splitted[2]);

                    numbers.Push(firstNumber);
                    numbers.Push(secondNumber);
                }

                else if (splitted[0] == "remove")
                {
                    int countToRemove = int.Parse(splitted[1]);

                    if (countToRemove > numbers.Count)
                    {
                        command = Console.ReadLine().ToLower();
                        splitted = command.Split();
                        continue;
                    }

                    else
                    {
                        for (int i = 0; i < countToRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
                splitted = command.Split();
            }

            int sum = numbers.Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
