using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            int sumClothes = 0;
            int rackNumber = 1;

            Stack<int> clothesStack = new Stack<int>(clothes);

            int iterations = clothesStack.Count;

            for (int i = 0; i < iterations; i++)
            {
                int currentCloth = clothesStack.Pop();

                if (sumClothes + currentCloth > rackCapacity)
                {
                    rackNumber++;
                    sumClothes = 0;
                }

                sumClothes += currentCloth;
            }

            Console.WriteLine(rackNumber);
        }
    }
}
