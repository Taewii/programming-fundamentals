using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
        string input = Console.ReadLine();

        while (input != "ready")
        {
            string[] commandArgs = input.Split(new char[] { ':', ',', '-' });
            string city = commandArgs[0];
            string[] typeAndCapacity = commandArgs.Skip(1).ToArray();

            if (!dict.ContainsKey(city))
            {
                dict.Add(city, new Dictionary<string, int>());
                for (int i = 0; i < typeAndCapacity.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        dict[city].Add(typeAndCapacity[i], 0);
                    }
                    else
                    {
                        dict[city][typeAndCapacity[i - 1]] = int.Parse(typeAndCapacity[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < typeAndCapacity.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (!dict[city].ContainsKey(typeAndCapacity[i]))
                        {
                            dict[city].Add(typeAndCapacity[i], 0);
                        }
                        else
                        {
                            dict[city][typeAndCapacity[i]] = int.Parse(typeAndCapacity[i + 1]);
                        }
                    }
                    else
                    {
                        dict[city][typeAndCapacity[i - 1]] = int.Parse(typeAndCapacity[i]);
                    }
                }
            }
            input = Console.ReadLine();
        }

        while (true)
        {
            input = Console.ReadLine();
            if (input == "travel time!")
            {
                break;
            }

            string[] commandsArgs = input.Split();
            string city = commandsArgs[0];
            int people = int.Parse(commandsArgs[1]);
            int totalSeats = dict[city].Values.Sum();

            if (people <= totalSeats)
            {
                Console.WriteLine($"{city} -> all {people} accommodated");
            }
            else
            {
                Console.WriteLine($"{city} -> all except {people - totalSeats} accommodated");
            }
        }
    }
}

