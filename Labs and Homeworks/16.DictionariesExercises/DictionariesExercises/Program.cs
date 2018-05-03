using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        while (input != "END")
        {
            string[] parameters = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (parameters[0] == "A")
            {
                phoneBook[parameters[1]] = parameters[2];
            }
            else if (parameters[0] == "S")
            {
                if (phoneBook.ContainsKey(parameters[1]))
                {
                    Console.WriteLine($"{parameters[1]} -> {phoneBook[parameters[1]]}");
                }
                else
                {
                    Console.WriteLine($"Contact {parameters[1]} does not exist.");
                }
            }
            input = Console.ReadLine();
        }
    }
}

