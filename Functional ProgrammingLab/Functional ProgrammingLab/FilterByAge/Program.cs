using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(", ");
                string name = input[0];
                int age = int.Parse(input[1]);

                if (!people.ContainsKey(name))
                {
                    people.Add(name, age);
                }
            }

            string condition = Console.ReadLine(); // older/younger
            int targetAge = int.Parse(Console.ReadLine());
            string format = Console.ReadLine(); // name, age ,  name age

            people = FilterNames(condition, targetAge, people);
            PrintNames(people, format);

        }

        static Dictionary<string, int> FilterNames(string condition, int age, Dictionary<string, int> people)
        {
            var filterNames = new Dictionary<string, int>();

            if (condition == "older")
            {
                filterNames = people.Where(name => name.Value >= age).ToDictionary(x => x.Key, y => y.Value);
            }

            else if (condition == "younger")
            {
                filterNames = people.Where(name => name.Value < age).ToDictionary(x => x.Key, y => y.Value);
            }

            return filterNames;
        }

        static void PrintNames(Dictionary<string, int> names, string format)
        {
            if (format == "name")
            {
                foreach (var name in names)
                {
                    Console.WriteLine(name.Key);
                }
            }

            else if (format == "age")
            {
                foreach (var name in names)
                {
                    Console.WriteLine(name.Value);
                }
            }

            else if (format == "name age")
            {
                foreach (var name in names)
                {
                    Console.WriteLine($"{name.Key} - {name.Value}");
                }
            }
        }
    }
}
