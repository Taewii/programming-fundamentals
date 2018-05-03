using System;
using System.Collections.Generic;
using System.Linq;

class p04_PokemonEvolution
{
    static void Main()
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        string input;
        while ((input = Console.ReadLine()) != "wubbalubbadubdub")
        {
            string[] commandArgs = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string name = commandArgs[0];

            if (commandArgs.Length > 1)
            {
                string evolutions = commandArgs[1] + " <-> " + commandArgs[2];

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<string>());
                }

                dict[name].Add(evolutions);
            }
            else if (dict.ContainsKey(name))
            {
                Console.WriteLine($"# {name}");
                foreach (var item in dict[name])
                {
                    Console.WriteLine(item);
                }
            }
        }

        foreach (var name in dict)
        {
            Console.WriteLine($"# {name.Key}");

            var ordered = name
                .Value
                .OrderByDescending(a => int.Parse(a.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)[1]))
                .ToList();

            foreach (var output in ordered)
            {
                Console.WriteLine(output);
            }
        }
    }
}

