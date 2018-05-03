using System;
using System.Text;
using System.Text.RegularExpressions;

class p03_Regexmon
{
    static void Main()
    {
        string input = Console.ReadLine();
        string firstPattern = @"[^A-Za-z-]+";
        string secondPattern = @"[A-Za-z]+-[A-Za-z]+";

        StringBuilder sb = new StringBuilder();
        sb.Append(input);

        for (int i = 1; i < 100000000; i++)
        {
            if (i % 2 == 1)
            {
                if (!Regex.IsMatch(sb.ToString(), firstPattern))
                {
                    break;
                }

                var firstMatch = Regex.Match(sb.ToString(), firstPattern);
                int matchIndex = firstMatch.Index;
                Console.WriteLine(firstMatch);
                sb.Remove(0, matchIndex + firstMatch.Length);
                continue;
            }
            else
            {
                if (!Regex.IsMatch(sb.ToString(), secondPattern))
                {
                    break;
                }

                var secondMatch = Regex.Match(sb.ToString(), secondPattern);
                int matchIndex = secondMatch.Index;
                Console.WriteLine(secondMatch);
                sb.Remove(0, matchIndex + secondMatch.Length);
                continue;
            }
        }
    }
}

