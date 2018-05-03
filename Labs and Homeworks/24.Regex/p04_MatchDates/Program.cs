using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var pattern = @"\b(?<day>[0-9]{2})([\/.-])(?<month>[A-Z][a-z]+)\1(?<year>[0-9]{4})\b";
        var input = Console.ReadLine();

        MatchCollection dates = Regex.Matches(input, pattern);
         
        foreach (Match item in dates)
        {
            //var date = item.Groups["day"].Value;
            //var month = item.Groups["month"].Value;
            //var year = item.Groups["year"].Value;
            //Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            Console.WriteLine($"Day: {item.Groups["day"]}, Month: {item.Groups["month"]}, Year: {item.Groups["year"]}");
        }
    }
}

