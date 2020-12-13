using System;
using System.Collections;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>(symbols);

            bool isValid = true;

            for (int i = 0; i < symbols.Length / 2; i++)
            {

                char currentChar = symbols[i];

                if (currentChar == '[')
                {
                    if (stack.Pop() != ']')
                    {
                        isValid = false;
                    }
                }

                else if (currentChar == '{')
                {
                    if (stack.Pop() != '}')
                    {
                        isValid = false;
                    }
                }


                else if (currentChar == '(')
                {
                    if (stack.Pop() != ')')
                    {
                        isValid = false;
                    }
                }

                else
                {
                    isValid = false;
                }
            }

            if (isValid)
            {
                Console.WriteLine("YES");
            }

            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
