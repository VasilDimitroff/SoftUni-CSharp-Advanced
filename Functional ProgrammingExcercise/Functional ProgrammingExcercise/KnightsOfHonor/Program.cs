using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                List<string> names = Console.ReadLine().Split().ToList();

                Action<List<string>> appendSir = x => x.Select(name => $"Sir {name}")
                .ToList()
                .ForEach(name => Console.WriteLine(name));

                appendSir(names);
            }
        }
    }
}
