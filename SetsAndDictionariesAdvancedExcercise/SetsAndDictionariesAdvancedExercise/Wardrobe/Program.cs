using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string color = input[0];

                for (int j = 1; j < input.Length; j++)
                {
                    string currentCloth = input[j];

                    if (!wardrobe.ContainsKey(color))
                    {
                        wardrobe.Add(color, new Dictionary<string, int>());
                    }

                    if (!wardrobe[color].ContainsKey(currentCloth))
                    {
                        wardrobe[color].Add(currentCloth, 0);
                    }

                    wardrobe[color][currentCloth]++;
                }
            }

            string[] searchInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string targetColor = searchInfo[0];
            string targetCloth = searchInfo[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cloth in color.Value)
                {
                    if (targetCloth == cloth.Key && targetColor == color.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }

                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
