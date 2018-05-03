using System;
using System.Collections.Generic;
using System.Linq;

class p03_TseamAccount
{
    static void Main()
    {
        List<string> account = Console.ReadLine().Split().ToList();

        string input;
        while ((input = Console.ReadLine()) != "Play!")
        {
            string[] tokens = input.Split();
            string command = tokens[0];
            string game = tokens[1];

            switch (command)
            {
                case "Install":
                    if (!account.Contains(game))
                    {
                        account.Add(game);
                    }
                    break;
                case "Uninstall":
                    if (account.Contains(game))
                    {
                        account.Remove(game);
                    }
                    break;
                case "Update":
                    if (account.Contains(game))
                    {
                        account.Remove(game);
                        account.Add(game);
                    }
                    break;
                case "Expansion":
                    string[] gameAndExpansion = game.Split('-');
                    game = gameAndExpansion[0];
                    string expansion = gameAndExpansion[1];
                    string resultString = game + ':' + expansion;

                    if (account.Contains(game))
                    {
                        int index = account.IndexOf(game);
                        account.Insert(index + 1, resultString);
                    }
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", account));
    }
}