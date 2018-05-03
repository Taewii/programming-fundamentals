using System;
using System.Text.RegularExpressions;
using System.Linq;

public class Example
{
    public static void Main()
    {
        string pattern = @"\+359( |-)2(\1)[0-9]{3}(\2)[0-9]{4}\b";
        string input = Console.ReadLine();

        MatchCollection phoneMatches = Regex.Matches(input, pattern);

        string[] matchedPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

        Console.WriteLine(string.Join(", ", matchedPhones));
    }
}