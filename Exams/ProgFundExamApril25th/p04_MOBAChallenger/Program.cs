using System;
using System.Collections.Generic;
using System.Linq;

class p04_MOBAChallenger
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> game = new Dictionary<string, Dictionary<string, int>>();

        string input;
        while ((input = Console.ReadLine()) != "Season end")
        {
            string[] tokens = input.Split();

            if (tokens.Length == 5)
            {
                string player = tokens[0];
                string position = tokens[2];
                int skill = int.Parse(tokens[4]);

                if (!game.ContainsKey(player))
                {
                    game.Add(player, new Dictionary<string, int>());
                }

                if (!game[player].ContainsKey(position))
                {
                    game[player].Add(position, skill);
                }
                else
                {
                    if (game[player][position] < skill)
                    {
                        game[player][position] = skill;
                    }
                }
            }
            else
            {
                string player1 = tokens[0];
                string player2 = tokens[2];
                bool hasSamePosition = false;
                string samePosition = string.Empty;

                if (game.ContainsKey(player1) && game.ContainsKey(player2))
                {
                    foreach (var position in game[player1].Keys)
                    {
                        if (game[player2].Keys.Contains(position))
                        {
                            hasSamePosition = true;
                            samePosition = position;
                            break;
                        }
                    }
                }

                if (hasSamePosition)
                {
                    if (game[player1][samePosition] > game[player2][samePosition])
                    {
                        game.Remove(player2);
                    }
                    else if (game[player1][samePosition] < game[player2][samePosition])
                    {
                        game.Remove(player1);
                    }
                }
            }
        }

        foreach (var player in game.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
            foreach (var skill in game[player.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"- {skill.Key} <::> {skill.Value}");
            }
        }
    }
}