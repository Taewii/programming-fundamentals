using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> emails = new Dictionary<string, string>();
        int counter = 0;
        string name = "";

        while (true)
        {
            counter++;
            string input = Console.ReadLine();

            if (input == "stop")
            {
                break;
            }

            if (counter % 2 == 1)
            {
                name = input;
                if (!emails.ContainsKey(input))
                {
                    emails.Add(input, "");
                }
            }
            else
            {
                emails[name] = input;
            }
        }

        foreach (var item in emails)
        {
            if (item.Value.EndsWith("us") || item.Value.EndsWith("uk"))
            {
                emails.Remove(item.Key);
                break;
            }
        }

        foreach (var item in emails)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

