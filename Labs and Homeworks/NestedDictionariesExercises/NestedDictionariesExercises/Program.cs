using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)    // works fine, compile error in judge. idk why
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(new string[] { " -> " }, StringSplitOptions.None);
            string color = inputSplit[0];
            string[] clothes = inputSplit[1].Split(',').ToArray();

            if (!wardrobe.ContainsKey(color))
            {
                wardrobe.Add(color, new Dictionary<string, int>());
                foreach (var item in clothes)
                {
                    wardrobe[color].Add(item, 1);
                }
            }
            else
            {
                foreach (var item in clothes)
                {
                    if (wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color][item] += 1;
                    }
                    else
                    {
                        wardrobe[color].Add(item, 1);
                    }
                }
            }
        }

        string[] itemNeeded = Console.ReadLine().Split();
        string colorNeeded = itemNeeded[0];
        string typeNeeded = itemNeeded[1];

        foreach (var color in wardrobe)
        {
            Console.WriteLine($"{color.Key} clothes:");

            foreach (var item in color.Value)
            {
                if (color.Key == colorNeeded && item.Key == typeNeeded)
                {
                    Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {item.Key} - {item.Value}");
                }
            }
        }
    }
}

