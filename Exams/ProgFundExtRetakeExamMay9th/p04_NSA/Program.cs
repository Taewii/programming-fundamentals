using System;
using System.Collections.Generic;
using System.Linq;

class p04_NSA
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> registry = new Dictionary<string, Dictionary<string, int>>();

        string input;
        while ((input = Console.ReadLine()) != "quit")
        {
            string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string country = tokens[0];
            string name = tokens[1];
            int score = int.Parse(tokens[2]);

            if (!registry.ContainsKey(country))
            {
                registry.Add(country, new Dictionary<string, int>());
            }

            registry[country][name] = score;
        }

        foreach (var country in registry.OrderByDescending(x => x.Value.Count))
        {
            Console.WriteLine($"Country: {country.Key}");
            foreach (var spy in country.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"**{spy.Key} : {spy.Value}");
            }
        }
    }
}
