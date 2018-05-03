using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Dictionary<string, double> cityTemperature = new Dictionary<string, double>();
        Dictionary<string, string> cityWeather = new Dictionary<string, string>();

        string pattern = @"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>[A-Za-z]+)\|";
        Regex reg = new Regex(pattern);

        while (input != "end")
        {
            Match match = reg.Match(input);

            if (reg.IsMatch(input))
            {
                string city = match.Groups["city"].Value;
                double temp = double.Parse(match.Groups["temp"].Value);
                string weather = match.Groups["weather"].Value;

                cityTemperature[city] = temp;
                cityWeather[city] = weather;
            }
            input = Console.ReadLine();
        }

        Dictionary<string, double> sortedTemp =
            cityTemperature.OrderBy(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var city in sortedTemp)
        {
            Console.WriteLine($"{city.Key} => {city.Value} => {cityWeather[city.Key]}");
        }
    }
}

