using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentItem = input[i];

                if (currentItem == '(')
                {
                    stack.Push(i);
                }

                else if (currentItem == ')')
                {
                    int firstChar = stack.Pop();

                    string expression = input.Substring(firstChar, i - firstChar + 1);

                    Console.WriteLine(expression);
                }
            }
        }
    }
}
