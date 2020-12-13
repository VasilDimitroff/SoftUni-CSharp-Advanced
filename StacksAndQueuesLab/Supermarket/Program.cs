using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var queue = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    foreach (var person in queue)
                    {
                        Console.WriteLine(person);
                    }

                    queue.Clear();
                }

                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
