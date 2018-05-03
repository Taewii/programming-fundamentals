using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string startAndEnd = Console.ReadLine();
        string text = Console.ReadLine();
        string pattern = @"([A-Za-z]+)[<:|:\\](.*)[<:|:\\]([A-Za-z]+)";

        Regex reg = new Regex(pattern);

        string result = "";

        Match match = reg.Match(startAndEnd);
        string start = match.Groups[1].Value;
        string end = match.Groups[3].Value;

        string pattern2 = $@"({start})(?<word>.*?)({end})";

        MatchCollection matches = Regex.Matches(text, pattern2);


        foreach (Match item in matches)
        {
            result += item.Groups[3].Value;
        }

        Console.WriteLine(result == "" ? "Empty result" : result);

        //   if (result == "")
        //   {
        //       Console.WriteLine("Empty result");
        //   }
        //   else
        //   {
        //       Console.WriteLine(result);
        //   }
    }
}

