using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string control = Console.ReadLine();
        List<string> input = Console.ReadLine().Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> result = new List<string>();

        string pattern = $@"\b{control}\b";
        var reg = new Regex(pattern);

        foreach (var item in input)
        {
            if (reg.IsMatch(item))
            {
                result.Add(item.Trim());
            }
        }

        Console.WriteLine(string.Join("\r\n", result));
    }
}

