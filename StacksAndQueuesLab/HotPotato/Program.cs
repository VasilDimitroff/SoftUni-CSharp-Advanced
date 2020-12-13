using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int toss = int.Parse(Console.ReadLine());

            Queue<string> children = new Queue<string>(kids);
            int index = 1;

            while (children.Count != 1)
            {
                if (index % toss == 0)
                {
                    string removedKid = children.Dequeue();
                    Console.WriteLine($"Removed {removedKid}");
                    index = 0;
                }

                else
                {
                    string dequed = children.Dequeue();
                    children.Enqueue(dequed);
                }

                index++;
            }

            Console.WriteLine($"Last is {children.Peek()}");
        }
    }
}
