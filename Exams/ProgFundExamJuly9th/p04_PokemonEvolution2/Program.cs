using System;
using System.Collections.Generic;
using System.Linq;

class p04_PokemonEvolution2
{
    static void Main() //this doesnt work. the other one does.
    {
        Dictionary<string, Dictionary<int, string>> dict = new Dictionary<string, Dictionary<int, string>>();

        string input;
        while ((input = Console.ReadLine()) != "wubbalubbadubdub")
        {
            string[] commandArgs = input.Split();

            if (commandArgs.Length > 1)
            {
                string name = commandArgs[0];
                string evolution = commandArgs[2];
                int index = int.Parse(commandArgs[4]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new Dictionary<int, string>());
                    dict[name].Add(index, evolution);
                }
                else
                {
                   //if (!dict[name].ContainsKey(index))
                    //{
                        dict[name].Add(index, evolution);
                    //}
                }
            }
            else
            {
                string name = commandArgs[0];

                if (dict.ContainsKey(name))
                {
                    Console.WriteLine($"# {name}");
                    foreach (var item in dict[name])
                    {
                        Console.WriteLine($"{item.Value} <-> {item.Key}");
                    }
                }
            }
        }

        foreach (var name in dict)
        {
            Console.WriteLine($"# {name.Key}");

            foreach (var item in dict[name.Key].OrderByDescending(x => x.Key))
            {
                Console.WriteLine($"{item.Value} <-> {item.Key}");
            }
        }
    }
}

