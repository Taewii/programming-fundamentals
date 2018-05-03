using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> minersManual = new Dictionary<string, int>();
        string input = "";
        string tempName = "";

        for (int i = 1; i < 999999999; i++)
        {
            input = Console.ReadLine();
            if (input == "stop")
            {
                break;
            }

            if (i % 2 == 1)
            {
                tempName = input;
            }

            if (i % 2 == 1 && !minersManual.ContainsKey(input))
            {
                tempName = input;
                minersManual.Add(input, 0);
            }
            else if (i % 2 == 1 && minersManual.ContainsKey(input))
            {
                continue;
            }
            else
            {
                minersManual[tempName] += int.Parse(input);
            }
        }

        foreach (var item in minersManual)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

