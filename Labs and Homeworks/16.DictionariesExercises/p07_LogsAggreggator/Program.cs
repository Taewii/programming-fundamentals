using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] commandArgs = input.Split(' ');
            int duration = int.Parse(commandArgs[2]);
            string name = commandArgs[1];
            string ip = commandArgs[0];

            if (!logs.ContainsKey(name))
            {
                logs.Add(name, new SortedDictionary<string, int>());
                logs[name].Add(ip, duration);
            }
            else
            {
                if (logs[name].ContainsKey(ip))
                {
                    logs[name][ip] += duration;
                }
                else
                {
                    logs[name].Add(ip, duration);
                }
            }
        }

        foreach (KeyValuePair<string, SortedDictionary<string, int>> name in logs)
        {
            string names = name.Key;
            int totalDuration = name.Value.Values.Sum();
            List<string> ipsList = name.Value.Keys.ToList();

            Console.WriteLine("{0}: {1} [{2}]", names, totalDuration, string.Join(", ", ipsList));
        }
    }
}


