﻿using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            Console.WriteLine(String.Join(Environment.NewLine, names));
        }
    }
}
