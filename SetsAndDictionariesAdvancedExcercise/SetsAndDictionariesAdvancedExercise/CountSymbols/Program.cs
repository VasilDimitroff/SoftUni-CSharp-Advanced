using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbols = new Dictionary<char, int>();

            string input = Console.ReadLine();

            foreach (var symbol in input)
            {
                if (!symbols.ContainsKey(symbol))
                {
                    symbols.Add(symbol, 0);
                }

                symbols[symbol]++;
            }

            foreach (var symbol in symbols.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
