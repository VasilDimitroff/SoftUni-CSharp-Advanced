using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestsAndPass = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] splitted = input.Split(":");
                string contest = splitted[0];
                string password = splitted[1];

                if (!contestsAndPass.ContainsKey(contest))
                {
                    contestsAndPass.Add(contest, password);
                }

                contestsAndPass[contest] = password;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            var students = new Dictionary<string, Dictionary<string, int>>();

            while (input != "end of submissions")
            {
                string[] splitted = input.Split("=>");

                string contest = splitted[0];
                string password = splitted[1];
                string username = splitted[2];
                int points = int.Parse(splitted[3]);

                if (contestsAndPass.ContainsKey(contest))
                {
                    if (contestsAndPass[contest] == password)
                    {
                        if (!students.ContainsKey(username))
                        {
                            students.Add(username, new Dictionary<string, int>());
                            students[username].Add(contest, points);

                        }

                        else if (students.ContainsKey(username))
                        {
                            if (students[username].ContainsKey(contest))
                            {
                                if (points > students[username][contest])
                                {
                                    students[username][contest] = points;
                                }
                            }
                            else
                            {
                                students[username].Add(contest, points);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            students = students.OrderByDescending(student => student.Value.Values.Sum())
                 .ToDictionary(a => a.Key, b => b.Value);

            int counter = 0;

            foreach (var student in students)
            {
                if (counter == 1)
                {
                    break;
                }

                Console.WriteLine($"Best candidate is {student.Key} with total {student.Value.Values.Sum()} points.");
                counter = 1;
            }

            Console.WriteLine("Ranking:");

            foreach (var student in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);

                foreach (var contest in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
