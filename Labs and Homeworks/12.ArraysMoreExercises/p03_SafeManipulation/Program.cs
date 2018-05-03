using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine().Split().ToList();
        string command = "";

        while (command != "END")
        {
            command = Console.ReadLine();
            if (command == "Distinct")
            {
                input = input.Distinct().ToList();
            }
            else if (command == "Reverse")
            {
                input.Reverse();
            }
            else if (command.Contains("Replace"))
            {
                string[] commands = command.Split().Skip(1).ToArray();
                if (int.Parse(commands[0]) >= input.Count || int.Parse(commands[0]) < 0)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    input.RemoveAt(int.Parse(commands[0]));
                    input.Insert(int.Parse(commands[0]), commands[1]);
                }
            }
            else
            {
                if (command != "END")
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
        Console.WriteLine(string.Join(", ", input));
    }
}

