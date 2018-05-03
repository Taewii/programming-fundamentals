using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine().Split().ToList();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string command = Console.ReadLine();

            switch (command)
            {
                case "Distinct":
                    input = input.Distinct().ToList();
                    break;
                case "Reverse":
                    input.Reverse();
                    break;
            }
            if (command.Contains("Replace"))
            {
                string[] commands = command.Split().Skip(1).ToArray();
                input.RemoveAt(int.Parse(commands[0]));
                input.Insert(int.Parse(commands[0]), commands[1]);
            }
        }
        Console.WriteLine(string.Join(", ", input));
    }
}

