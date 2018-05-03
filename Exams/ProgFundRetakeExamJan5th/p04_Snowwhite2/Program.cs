using System;
using System.Collections.Generic;
using System.Linq;

class p04_Snowwhite2
{
    static void Main()
    {
        Dictionary<string, int> dwarfs = new Dictionary<string, int>();
        Dictionary<string, int> colors = new Dictionary<string, int>();

        string input;
        while ((input = Console.ReadLine()) != "Once upon a time")
        {
            string[] commandArgs = input.Split(new string[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);
            string name = commandArgs[0];
            string hatColor = commandArgs[1];
            int physics = int.Parse(commandArgs[2]);
            string hatAndPhysics = name + " <:> " + hatColor;

            if (!colors.ContainsKey(hatColor))
            {
                colors.Add(hatColor, 1);
            }
            else
            {
                colors[hatColor]++;
            }

            if (!dwarfs.ContainsKey(hatAndPhysics))
            {
                dwarfs.Add(hatAndPhysics, physics);
            }
            else
            {
                if (dwarfs[hatAndPhysics] < physics)
                {
                    dwarfs[hatAndPhysics] = physics;
                }
            }
        }

        Dictionary<string, int> sortedDwarfs = dwarfs
            .OrderByDescending(x => x.Value)
            .ThenByDescending(x => colors[x.Key.Split(new string[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries)[1]])
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var dwarf in sortedDwarfs)
        {
            string dwarfId = dwarf.Key;
            int physics = dwarf.Value;

            string[] tokens = dwarfId.Split(new string[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[0];
            string color = tokens[1];

            Console.WriteLine($"({color}) {name} <-> {physics}");
        }
    }
}

