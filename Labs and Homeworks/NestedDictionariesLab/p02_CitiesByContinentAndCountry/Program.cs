﻿using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string continent = input[0];
            string country = input[1];
            string city = input[2];

            if (!dict.ContainsKey(continent))
            {
                dict.Add(continent, new Dictionary<string, List<string>>());
                dict[continent].Add(country, new List<string>());
                dict[continent][country].Add(city);
            }
            else if (dict.ContainsKey(continent) && (dict[continent].ContainsKey(country)))
            {
                dict[continent][country].Add(city);
            }
            else if (dict.ContainsKey(continent) && !(dict[continent].ContainsKey(country)))
            {
                dict[continent].Add(country, new List<string>());
                dict[continent][country].Add(city);
            }
        }

        foreach (var continent in dict)
        {
            Console.WriteLine($"{continent.Key}:");
            foreach (var country in continent.Value)
            {
                Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
            }
        }
    }
}

