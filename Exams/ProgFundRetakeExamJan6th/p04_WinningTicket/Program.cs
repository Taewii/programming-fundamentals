using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class p04_WinningTicket
{
    static void Main()   //70/100   i fucked the invalid ticket/no match stuff real bad
    {
        string[] input = Console.ReadLine()
            .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(t => t.Trim()).ToArray();
        string pattern = @"([@]{6,})?([$]{6,})?([\^]{6,})?([#]{6,})?";

        foreach (var item in input)
        {
            var matches = Regex.Matches(item, pattern);
        }

        foreach (var item in input)
        {
            if (item.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            var match = Regex.Matches(item, pattern);

            List<string> idk = new List<string>();

            foreach (Match mt in match)
            {
                if (mt.Length != 0)
                {
                    idk.Add(mt.ToString());
                }
            }

            if (idk.Count == 0)
            {
                // if ("$#^@".Contains(idk[0]))
                // {
                //     Console.WriteLine("invalid ticket");
                //     continue;
                // }
                if ("$#^@".Contains(item))
                {
                    Console.WriteLine($"ticket \"{item}\" - no match");
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
               
            }

            if (idk.Count != 1)
            {
                char str = idk[0].First();
                char str2 = idk[1].First();
                if (str != str2)
                {
                    Console.WriteLine($"ticket \"{item}\" - no match");
                    continue;
                }
                
            }

            if (idk.Count == 1)
            {
                if (idk[0].Length < 10)
                {
                    Console.WriteLine($"ticket \"{item}\" - no match");
                    continue;
                }
                string str = idk[0];
                
                if (str[0] != str[11])
                {
                    Console.WriteLine($"ticket \"{item}\" - no match");
                    continue;
                }               
            }

            string toStr = ""; 
            if (idk.Count > 1)
            {
                toStr = idk[0].ToString() + idk[1].ToString();
            }
            else
            {
                toStr = idk[0].ToString();
            }

            if (toStr.Length / 2 <= 9 && toStr.Length / 2 >= 6)
            {
                Console.WriteLine($"ticket \"{item}\" - {toStr.Length / 2}{toStr.ToCharArray()[1]}");
            }
            else if (toStr.Length / 2 == 10)
            {
                Console.WriteLine($"ticket \"{item}\" - {toStr.Length / 2}{toStr.ToCharArray()[1]} Jackpot!");
            }
        }
    }
}

