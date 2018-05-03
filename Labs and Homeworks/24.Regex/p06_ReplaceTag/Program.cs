using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
        var replacement = @"[URL href=$1]$2[/URL]";
        var input = Console.ReadLine();

        List<string> result = new List<string>();

        while (input != "end")
        {
            var idk = Regex.Replace(input, pattern, replacement);
            result.Add(idk);
            
            input = Console.ReadLine();
        }

        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}

