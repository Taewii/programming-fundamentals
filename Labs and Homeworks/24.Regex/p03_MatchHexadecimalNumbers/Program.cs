using System;
using System.Text.RegularExpressions;
using System.Linq;

public class Example
{
    public static void Main()
    {
        string pattern = @"\b(?:0x)?[0-9-A-F]+\b";
        string input = Console.ReadLine();

        MatchCollection phoneMatches = Regex.Matches(input, pattern);

        string[] matchedPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

        Console.WriteLine(string.Join(" ", matchedPhones));
    }
}