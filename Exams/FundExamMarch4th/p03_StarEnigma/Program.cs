using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class p03_StarEnigma
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedSet<string> attackedPlanetsNames = new SortedSet<string>();
        SortedSet<string> destroyedPlanetsNames = new SortedSet<string>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            int count = DecryptStringCount(input);
            string decryptedString = DecryptString(input, count);
            string pattern = @"@(?<planet>[A-Za-z]+)[^@\-!:>]*:(?<population>[0-9]+)[^@\-!:>]*!(?<attack>\w)![^@\-!:>]*->(?<soldiers>\d+)";

            Match match = Regex.Match(decryptedString, pattern);

            string planetName = match.Groups["planet"].Value;
            string attack = match.Groups["attack"].Value;

            if (attack == "A")
            {
                attackedPlanetsNames.Add(planetName);
            }
            else if (attack == "D")
            {
                destroyedPlanetsNames.Add(planetName);
            }
        }

        Console.WriteLine($"Attacked planets: {attackedPlanetsNames.Count}");
        foreach (var planet in attackedPlanetsNames)
        {
            Console.WriteLine($"-> {planet}");
        }
        Console.WriteLine($"Destroyed planets: {destroyedPlanetsNames.Count}");
        foreach (var planet in destroyedPlanetsNames)
        {
            Console.WriteLine($"-> {planet}");
        }
    }
        
    static string DecryptString(string input, int count)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            sb.Append((char)(input[i] - count));
        }

        return sb.ToString();
    }

    static int DecryptStringCount(string input)
    {
        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 's' || input[i] == 't' || input[i] == 'a' || input[i] == 'r' ||
                input[i] == 'S' || input[i] == 'T' || input[i] == 'A' || input[i] == 'R')
            {
                count++;
            }
        }

        return count;
    }
}
