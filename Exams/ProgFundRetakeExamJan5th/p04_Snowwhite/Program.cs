using System;
using System.Collections.Generic;
using System.Linq;

class p04_Snowwhite
{                      // sorting the ints doesnt work (or i just dont know how to do it eyyyyyyyyyyyy)
    static void Main() // needs two dictionaries of name + color, int and name, colorCount
    {
        Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

        string input;
        while ((input = Console.ReadLine()) != "Once upon a time")
        {
            string[] commandArgs = input.Split(" <:> ");
            string hatColor = commandArgs[0];
            string name = commandArgs[1];
            int physics = int.Parse(commandArgs[2]);

            if (!dict.ContainsKey(name))
            {
                dict.Add(name, new Dictionary<string, int>());
                dict[name].Add(hatColor, physics);
            }
            else
            {
                if (dict[name].ContainsKey(hatColor))
                {
                    if (dict[name][hatColor] < physics)
                    {
                        dict[name][hatColor] = physics;
                    }
                }
                else
                {
                    dict[name].Add(hatColor, physics);
                }
            }
        }

        foreach (var dwarf in dict
        .OrderByDescending(x => x.Value.Keys).ThenByDescending(h => h.Value.Count))
        {
            foreach (var hat in dwarf.Value)
            {
                Console.WriteLine($"({dwarf.Key}) {hat.Key} <-> {hat.Value}");
            }
        }
    }
}

