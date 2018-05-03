using System;
using System.Collections.Generic;
using System.Linq;

class p04_CODEPhoenix
{
    static void Main()
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        string input;
        while ((input = Console.ReadLine()) != "Blaze it!")
        {
            string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string creature = tokens[0];
            string squadMate = tokens[1];

            if (creature == squadMate)
            {
                continue;
            }

            if (!dict.ContainsKey(creature))
            {
                dict.Add(creature, new List<string>());
            }

            if (!dict[creature].Contains(squadMate))
            {
                dict[creature].Add(squadMate);
            }
        }

        Dictionary<string, int> creatureAndCount = new Dictionary<string, int>();

        foreach (var creature in dict)
        {
            creatureAndCount.Add(creature.Key, creature.Value.Count);
        }

        foreach (var item in dict)
        {
            foreach (var item2 in dict)
            {
                if (item.Value.Contains(item2.Key))
                {
                    if (item2.Value.Contains(item.Key))
                    {
                        creatureAndCount[item.Key]--;                      
                    }                    
                }
            }
        }

        foreach (var idk in creatureAndCount.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{idk.Key} : {idk.Value}");
        }
    }
}