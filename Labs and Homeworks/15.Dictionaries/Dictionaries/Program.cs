using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

        var result = new SortedDictionary<double, int>();

        foreach (var item in numbers)
        {
            if (result.ContainsKey(item))
            {
                result[item]++;               
            }
            else
            {
                result[item] = 1;
            }
        }

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

