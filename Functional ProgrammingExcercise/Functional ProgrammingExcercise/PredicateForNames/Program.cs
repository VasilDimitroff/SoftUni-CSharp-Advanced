using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string[], string[]> filterNames = x => x.Where(name => name.Length <= targetLength).ToArray();
            Func<string[], string> printNames = x => String.Join(Environment.NewLine, filterNames(names));

            Console.WriteLine(printNames(names));


        }
    }
}
