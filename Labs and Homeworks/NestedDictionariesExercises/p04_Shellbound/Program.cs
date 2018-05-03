using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Dictionary<string, HashSet<int>> shells = new Dictionary<string, HashSet<int>>();

        while (input != "Aggregate")
        {
            string[] commandArgs = input.Split();
            string city = commandArgs[0];
            int quantity = int.Parse(commandArgs[1]);

            if (!shells.ContainsKey(city))
            {
                shells.Add(city, new HashSet<int>());
            }
            shells[city].Add(quantity);
            input = Console.ReadLine();
        }

        foreach (var shell in shells)
        {
            Console.WriteLine($"{shell.Key} -> {string.Join(", ", shell.Value)} ({Math.Round(shell.Value.Sum() - shell.Value.Average())})");
        }
    }
}

