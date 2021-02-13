using System;
using System.Linq;
using System.Collections.Generic;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            List<char> startFilter = new List<char>();
            List<char> endFilter = new List<char>();
            List<int> lengthFilter = new List<int>();
            List<string> containsFilter = new List<string>();

            while (true)
            {
                string commandLine = Console.ReadLine();

                if (commandLine == "Print")
                {
                    foreach (var name in names)
                    {
                        if (startFilter.Contains(name[0]) || endFilter.Contains(name[name.Length - 1])
                            || lengthFilter.Contains(name.Length) || containsFilter.Any(x => name.Contains(x)))
                        {
                            continue;
                        }

                        Console.Write(name + " ");
                    }

                    break;
                }

                // Add

                if (commandLine.StartsWith("Add") && commandLine.Contains("Starts"))
                {
                    startFilter.Add(commandLine[commandLine.Length - 1]);
                }

                else if (commandLine.StartsWith("Add") && commandLine.Contains("Ends"))
                {
                    endFilter.Add(commandLine[commandLine.Length - 1]);
                }

                else if (commandLine.StartsWith("Add") && commandLine.Contains("Length"))
                {
                    string[] splittedCommand = commandLine.Split(";");

                    int length = int.Parse(splittedCommand[2]);

                    lengthFilter.Add(length);
                }

                else if (commandLine.StartsWith("Add") && commandLine.Contains("Contains"))
                {
                    string[] splittedCommand = commandLine.Split(";");

                    string contains = splittedCommand[2];

                    containsFilter.Add(contains);
                }

                // Remove

                else if (commandLine.StartsWith("Remove") && commandLine.Contains("Starts"))
                {
                    startFilter.Remove(commandLine[commandLine.Length - 1]);
                }

                else if (commandLine.StartsWith("Remove") && commandLine.Contains("Ends"))
                {
                    endFilter.Remove(commandLine[commandLine.Length - 1]);
                }

                else if (commandLine.StartsWith("Remove") && commandLine.Contains("Length"))
                {
                    string[] splittedCommand = commandLine.Split(";");

                    int length = int.Parse(splittedCommand[2]);

                    lengthFilter.Remove(length);
                }

                else if (commandLine.StartsWith("Remove") && commandLine.Contains("Contains"))
                {
                    string[] splittedCommand = commandLine.Split(";");

                    string contains = splittedCommand[2];

                    containsFilter.Remove(contains);
                }
            }
        }
    }
}