using System;
using System.Collections.Generic;
using System.Linq;

class p02_SoftUniKaraoke
{
    static void Main()
    {
        string[] participants = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        string[] songs = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, SortedSet<string>> awards = new Dictionary<string, SortedSet<string>>();

        string input;
        while ((input = Console.ReadLine()) != "dawn")
        {
            string[] tokens = input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[0];
            string song = tokens[1];
            string award = tokens[2];

            if (participants.Contains(name) && songs.Contains(song))
            {
                if (!awards.ContainsKey(name))
                {
                    awards.Add(name, new SortedSet<string>());
                    awards[name].Add(award);
                }
                else
                {
                    if (!awards[name].Contains(award))
                    {
                        awards[name].Add(award);
                    }
                }
            }
        }

        if (awards.Count == 0)
        {
            Console.WriteLine("No awards");
            return;
        }

        foreach (var item in awards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
            foreach (var award in item.Value)
            {
                Console.WriteLine($"--{award}");
            }
        }
    }
}

