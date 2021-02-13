using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<decimal> { grade });
                }

                else
                {
                    students[name].Add(grade);
                }


            }

            foreach (var student in students)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var grade in student.Value)
                {
                    sb.Append($"{grade:f2} ");
                }
                Console.WriteLine($"{student.Key} -> {sb}(avg: {student.Value.Average():f2})");

            }
        }
    }
}
