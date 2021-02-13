using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstSize = sizes[0];
            int secondSize = sizes[1];

            HashSet<int> firstSet = new HashSet<int>(firstSize);
            HashSet<int> secondSet = new HashSet<int>(secondSize);
            HashSet<int> togetherNumbers = new HashSet<int>();


            for (int i = 0; i < firstSize; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                firstSet.Add(currentNumber);
            }

            for (int i = 0; i < secondSize; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                secondSet.Add(currentNumber);

                if (firstSet.Contains(currentNumber))
                {
                    togetherNumbers.Add(currentNumber);
                }
            }

            HashSet<int> finalSet = new HashSet<int>();

            foreach (var number in firstSet)
            {
                if (togetherNumbers.Contains(number))
                {
                    finalSet.Add(number);
                }
            }



            Console.WriteLine(String.Join(" ", finalSet));


        }
    }
}
