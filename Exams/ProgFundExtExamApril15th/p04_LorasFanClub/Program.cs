using System;
using System.Collections.Generic;
using System.Linq;

class p04_LorasFanClub
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> fans = new Dictionary<string, Dictionary<string, int>>();

        string input;
        while ((input = Console.ReadLine()) != "Make a decision already!")
        {
            string[] tokens = input.Split();
            string name = tokens[0];

            if (!input.Contains("does Gyubek!"))
            {
                string trait = tokens[1];
                int value = int.Parse(tokens[2]);

                if (!fans.ContainsKey(name))
                {
                    fans.Add(name, new Dictionary<string, int>());
                }

                if (fans[name].ContainsKey(trait))
                {
                    //if (fans[name][trait] < value) \\ mistake 1
                    if (fans[name][trait] < AddValue(trait, value))
                    {
                        fans[name][trait] = AddValue(trait, value);
                    }
                }
                else
                {
                    fans[name].Add(trait, AddValue(trait, value));
                }
            }
            else
            {
                if (fans.ContainsKey(name))
                {
                    //fans[name].Clear();  Premahvame samo polojitelnite    mistake 2

                    //fans[name] = fans[name].Where(x => fans[name][x.Key] <= 0).ToDictionary(x => x.Key, x => x.Value);
                    // ^^^ lambda for the list and foreaches below

                    List<string> traitsToRemove = new List<string>();
                    foreach (string currentTrait in fans[name].Keys)
                    {
                        if (fans[name][currentTrait] > 0)
                        {
                            traitsToRemove.Add(currentTrait);
                        }
                    }
                    foreach (string traitToRemove in traitsToRemove)
                    {
                        fans[name].Remove(traitToRemove);
                    }
                }
            }
        }

        foreach (var boy in fans.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
        {
            Console.WriteLine($"# {boy.Key}: {boy.Value.Values.Sum()}");
            foreach (var trait in boy.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"!!! {trait.Key} -> {trait.Value}");
            }
        }
    }

    static int AddValue(string trait, int value)
    {
        switch (trait)
        {
            case "Greedy":
            case "Rude":
            case "Dumb":
                value *= -1;
                break;
            case "Kind":
                value *= 2;
                break;
            case "Handsome":
                value *= 3;
                break;
            case "Smart":
                value *= 5;
                break;
            default:
                return value;
        }
        return value;
    }
}