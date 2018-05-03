using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var words = Console.ReadLine().ToLower().Split().ToArray();

        var result = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (result.ContainsKey(word))
            {
                result[word]++;
            }
            else
            {
                result[word] = 1;
            }
        }

        var oddResults = new List<string>();

        foreach (var item in result)
        {
            if (item.Value % 2 == 1)
            {
                oddResults.Add(item.Key);
            }
        }

        Console.WriteLine(String.Join(", ", oddResults));
    }
}

