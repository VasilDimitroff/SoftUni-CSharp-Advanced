using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV-Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vloggerFollowers = new Dictionary<string, HashSet<string>>();
            var vloggerFollowings = new Dictionary<string, HashSet<string>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] splitted = input.Split();
                string vloggerName = splitted[0];

                if (splitted[1] == "joined")
                {
                    if (!vloggerFollowers.ContainsKey(vloggerName))
                    {
                        vloggerFollowers.Add(vloggerName, new HashSet<string>());
                        vloggerFollowings.Add(vloggerName, new HashSet<string>());
                    }
                }

                else if (splitted[1] == "followed")
                {
                    string follower = vloggerName;
                    string followedVlogger = splitted[2];

                    if (follower != followedVlogger)
                    {
                        if (vloggerFollowers.ContainsKey(follower) && vloggerFollowers.ContainsKey(followedVlogger))
                        {
                            vloggerFollowers[followedVlogger].Add(follower);
                            vloggerFollowings[follower].Add(followedVlogger);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggerFollowings.Count} vloggers in its logs.");

            int counter = 1;

            vloggerFollowers = vloggerFollowers.OrderByDescending(x => x.Value.Count)
                .ThenBy(kvp => vloggerFollowings[kvp.Key].Count)
                .ToDictionary(a => a.Key, b => b.Value);

            var mostFamous = vloggerFollowers.First();


            Console.WriteLine($"{counter++}. {mostFamous.Key} : {mostFamous.Value.Count} followers, {vloggerFollowings[mostFamous.Key].Count} following");

            if (mostFamous.Value.Count > 0)
            {
                foreach (var follower in mostFamous.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"*  {follower}");
                }
            }

            foreach (var vlogger in vloggerFollowers.Skip(1))
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vloggerFollowers[vlogger.Key].Count} followers, {vloggerFollowings[vlogger.Key].Count} following");
                counter++;
            }
        }


    }
}
