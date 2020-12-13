using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Array.Reverse(input);

            Stack<string> stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                char sign = char.Parse(stack.Pop());
                int second = int.Parse(stack.Pop());

                int result = 0;

                if (sign == '+')
                {
                    result = first + second;
                }

                else if (sign == '-')
                {
                    result = first - second;
                }

                stack.Push(result.ToString());
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
