using System;
using System.Collections.Generic;
using System.Linq;

class p04_RainAir
{
    static void Main()
    {
        Dictionary<string, List<int>> idk = new Dictionary<string, List<int>>();

        string input;
        while ((input = Console.ReadLine()) != "I believe I can fly!")
        {
            string[] tokens = input.Split();
            string name = tokens[0];
            if (tokens.Contains("="))
            {
                string secondName = tokens[2];

                if (!idk.ContainsKey(name))
                {
                    idk.Add(name, new List<int>());
                    idk[name].AddRange(idk[secondName]);
                }
                else
                {
                    idk[name].Clear();
                    idk[name].AddRange(idk[secondName]);
                }
              
            }
            else
            {
                int[] flights = tokens.Skip(1).Select(int.Parse).ToArray();

                if (!idk.ContainsKey(name))
                {
                    idk.Add(name, new List<int>());
                }

                idk[name].AddRange(flights);
            }
        }    

        foreach (var item in idk.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            Console.WriteLine($"#{item.Key} ::: {string.Join(", ", item.Value.OrderBy(x => x))}");            
        }
    }
}

