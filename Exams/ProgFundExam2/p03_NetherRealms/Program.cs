using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class p03_NetherRealms
{
    static void Main()  //20/100 zero tests pass..
    {
        string[] input = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        string letters = @"[^0-9+\-*\/.]";
        string numbers = @"[0-9-+.]+";
        string symbols = @"[\*\/]";

        Dictionary<string, string> demons = new Dictionary<string, string>();

        foreach (var item in input)
        {
            MatchCollection letterMatches = Regex.Matches(item, letters);
            MatchCollection numberMatches = Regex.Matches(item, numbers);
            MatchCollection symbolMatches = Regex.Matches(item, symbols);

            string word = "";
            foreach (Match letter in letterMatches)
            {
                word += letter.ToString();
            }

            long health = 0;

            foreach (char ch in word.ToCharArray())
            {
                health += ch;
            }

            float damage = 0;          

            foreach (var num in numberMatches)
            {
                float number = (float)Convert.ToDouble(num.ToString());
                damage += number;
            }

            foreach (var sym in symbolMatches)
            {
                char symbol = Convert.ToChar(sym.ToString());

                if (symbol == '*')
                {
                    damage *= 2;
                }
                else if (symbol == '/')
                {
                    damage /= 2;
                }
            }

            string demon = $"{item} - {health} health, {damage:f2} damage";         
            demons.Add(item, demon);
        }

        foreach (var demon in demons.OrderBy(x => x.Key))
        {
            Console.WriteLine(demon.Value);
        }
    }
}

