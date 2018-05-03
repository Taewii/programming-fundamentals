using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
        string input = Console.ReadLine();

        while (input != "report")
        {
            string[] commandArgs = input.Split('|');
            string country = commandArgs[1];
            string city = commandArgs[0];
            long pop = long.Parse(commandArgs[2]);

            if (!countries.ContainsKey(country))
            {
                countries.Add(country, new Dictionary<string, long>());
                countries[country].Add(city, pop);
            }
            else
            {
                countries[country].Add(city, pop);
            }
            input = Console.ReadLine();
        }

        foreach (var country in countries.OrderByDescending(n => n.Value.Values.Sum()))
        {
            Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

            foreach (var city in country.Value.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }
}

