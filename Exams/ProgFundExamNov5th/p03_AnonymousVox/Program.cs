using System;
using System.Text.RegularExpressions;

class p03_AnonymousVox
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] placeholders = Console.ReadLine().Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
        string pattern = @"([A-Za-z]+)(.+)(\1)";

        var matches = Regex.Matches(input, pattern);

        int count = 0;
        foreach (Match match in matches)
        {
            string decoded = match.Groups[1] + placeholders[count] + match.Groups[3];
            count++;

            input = input.Replace(match.Value, decoded);
        }
        Console.WriteLine(input);
    }
}

