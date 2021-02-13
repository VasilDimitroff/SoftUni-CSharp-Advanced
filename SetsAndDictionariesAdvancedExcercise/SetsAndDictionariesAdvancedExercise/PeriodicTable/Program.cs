using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string[] currentElements = Console.ReadLine().Split();

                for (int j = 0; j < currentElements.Length; j++)
                {
                    string currentElement = currentElements[j];
                    elements.Add(currentElement);
                }
            }

            elements = elements.OrderBy(x => x).ToHashSet();

            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
