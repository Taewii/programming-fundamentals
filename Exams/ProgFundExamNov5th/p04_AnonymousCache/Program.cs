using System;
using System.Collections.Generic;
using System.Linq;

class p04_AnonymousCache
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();
        Dictionary<string, long> sorted = new Dictionary<string, long>();

        string input;
        while ((input = Console.ReadLine()) != "thetinggoesskrra")
        {
            string[] tokens = input.Split(new[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length < 3)
            {
                string dataSet = tokens[0];

                if (!dict.ContainsKey(dataSet))
                {
                    dict.Add(dataSet, new Dictionary<string, long>());
                }
            }
            else
            {
                string dataKey = tokens[0];
                long dataSize = long.Parse(tokens[1]);
                string dataSet = tokens[2];

                if (!dict.ContainsKey(dataSet))
                {
                    dict.Add(dataSet, new Dictionary<string, long>());
                    dict[dataSet].Add(dataKey, dataSize);
                }
                else
                {
                    dict[dataSet].Add(dataKey, dataSize);
                }
            }
        }

        foreach (var item in dict)
        {
            long sum = item.Value.Values.Sum();

            sorted.Add(item.Key, sum);
            sorted = sorted.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        if (dict.Count > 1)
        {
            foreach (var item in sorted)
            {
                Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value}");
                break;
            }

            var first = sorted.First();
            string firstKey = first.Key;

            foreach (var item in dict[firstKey])
            {
                Console.WriteLine($"$.{item.Key}");
            }
        }
    }
}

