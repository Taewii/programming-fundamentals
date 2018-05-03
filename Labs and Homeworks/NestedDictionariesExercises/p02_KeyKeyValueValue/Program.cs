using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string keyControl = Console.ReadLine();
        string valueControl = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new string[] { " => ", ";" }, StringSplitOptions.RemoveEmptyEntries);
            string key = input[0];
            string[] values = input.Skip(1).ToArray();

            if (!dict.ContainsKey(key))
            {
                dict.Add(key, new List<string>());
                dict[key].AddRange(values);
            }
        }

        foreach (var key in dict)
        {
            if (key.Key.Contains(keyControl))
            {
                Console.WriteLine($"{key.Key}:");

                for (int i = 0; i < key.Value.Count; i++)
                {
                    if (key.Value[i].Contains(valueControl))
                    {
                        Console.WriteLine($"-{key.Value[i]}");
                    }
                }
            }
        }
    }
}

