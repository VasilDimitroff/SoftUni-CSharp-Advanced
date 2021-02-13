using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            prices.Select(x => x + 0.20 * x).ToList().ForEach(x => Console.WriteLine($"{x:f2}"));
        }
    }
}
