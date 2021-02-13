using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int[], List<int>> diviningNumbers = (x, dividers) =>
            {
                List<int> dividingNums = new List<int>();

                for (int i = 1; i <= x; i++)
                {
                    bool isDivisible = false;
                    int counter = 0;

                    for (int j = 0; j < dividers.Length; j++)
                    {
                        if (i % dividers[j] == 0)
                        {
                            counter++;

                            if (counter == dividers.Length)
                            {
                                isDivisible = true;
                                dividingNums.Add(i);
                            }
                        }
                    }
                }

                return dividingNums;
            };

            Func<List<int>, string> printNumbers = nums => String.Join(" ", nums);

            Console.WriteLine(printNumbers(diviningNumbers(end, dividers)));
        }
    }
}
