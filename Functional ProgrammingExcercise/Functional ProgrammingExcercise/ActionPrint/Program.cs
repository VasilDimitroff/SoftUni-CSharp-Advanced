using System;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string[]> printNames = x => Console
            .WriteLine(String.Join(Environment.NewLine, names));

            printNames(names);
        }
    }
}
