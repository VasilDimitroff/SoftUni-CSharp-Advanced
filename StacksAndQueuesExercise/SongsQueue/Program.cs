using System;
using System.Collections;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> songs = new Queue<string>(input);

            string command = Console.ReadLine();

            while (songs.Count != 0)
            {
                if (command.Contains("Add"))
                {
                    string songName = command.Substring(4, command.Length - 4);

                    if (songs.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }

                    else
                    {
                        songs.Enqueue(songName);
                    }
                }

                else if (command == "Play")
                {
                    songs.Dequeue();
                }

                else if (command == "Show")
                {
                    Console.WriteLine(String.Join(", ", songs));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
