using System;
using System.Collections.Generic;
using System.Linq;

class p04_ForceBook
{
    static void Main()  // its kinda fucked up, but it works 100/100, cba fixing it
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        string input;
        while ((input = Console.ReadLine()) != "Lumpawaroo")
        {
            string[] commandArgs = input.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string forceSide = commandArgs[0];
            string forceUser = commandArgs[1];

            if (input.Contains("|"))
            {
                if (!dict.ContainsKey(forceSide))
                {
                    dict.Add(forceSide, new List<string>());                             
                }
                AddUser(forceUser, forceSide, dict);
            }
            else if (input.Contains(" -> "))
            {
                forceSide = commandArgs[1];
                forceUser = commandArgs[0];
                bool userExists = false;
                string previousUserSide = string.Empty;

                foreach (var item in dict)
                {
                    if (dict[item.Key].Contains(forceUser))
                    {
                        userExists = true;
                        previousUserSide = item.Key;
                        break;
                    }
                }

                if (userExists)
                {
                    dict[previousUserSide].Remove(forceUser);
                    if (!dict.ContainsKey(forceSide))
                    {
                        dict.Add(forceSide, new List<string>());
                    }
                    AddUserConsoleWriteLine(forceUser, forceSide, dict);
                }
                else
                {
                    if (!dict.ContainsKey(forceSide))
                    {
                        dict.Add(forceSide, new List<string>());
                    }
                    AddUserConsoleWriteLine(forceUser, forceSide, dict);
                }
            }
        }

        foreach (var side in dict.Where(x => x.Value.Count != 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
            foreach (var player in dict[side.Key].OrderBy(x => x))
            {
                Console.WriteLine($"! {player}");
            }
        }
    }

    static void AddUser(string forceUser, string forceSide, Dictionary<string, List<string>> dict)
    {
        foreach (var item in dict)
        {
            if (dict[item.Key].Contains(forceUser))
            {
                return;
            }
        }
        dict[forceSide].Add(forceUser);
    }

    static void AddUserConsoleWriteLine(string forceUser, string forceSide, Dictionary<string, List<string>> dict)
    {
        foreach (var item in dict)
        {
            if (dict[item.Key].Contains(forceUser))
            {
                return;
            }
        }
        dict[forceSide].Add(forceUser);
        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
    }
}