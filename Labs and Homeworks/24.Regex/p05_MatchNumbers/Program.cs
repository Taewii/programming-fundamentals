using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
        var input = Console.ReadLine();

        var numberMatches = Regex.Matches(input, pattern);

        foreach (Match number in numberMatches)
        {
            Console.Write(number.Value + " ");
        }
    }
}

