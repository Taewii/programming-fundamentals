using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Dictionary<string, string> logins = new Dictionary<string, string>();

        string[] commandArgs;
        string name;
        string password;
        int counter = 0;

        while (input != "login")
        {
            commandArgs = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            name = commandArgs[0];
            password = commandArgs[1];

            if (!logins.ContainsKey(name))
            {
                logins.Add(name, password);
            }
            else
            {
                logins[name] = password;
            }
            input = Console.ReadLine();
        }

        while (true)
        {
            input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            commandArgs = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            name = commandArgs[0];
            password = commandArgs[1];

            if (!logins.ContainsKey(name) || !logins.ContainsValue(password))
            {
                Console.WriteLine($"{name}: login failed");
                counter++;
            }
            else
            {
                Console.WriteLine($"{name}: logged in successfully");
            }
        }

        if (counter != 0)
        {
            Console.WriteLine($"unsuccessful login attempts: {counter}");
        }
    }
}

