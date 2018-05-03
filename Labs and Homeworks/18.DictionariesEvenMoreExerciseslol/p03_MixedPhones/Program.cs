using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        SortedDictionary<string, long> phonebook = new SortedDictionary<string, long>();

        while (input != "Over")
        {
            string[] commandArgs = input.Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
            long number = 0;
            string name = "";

            try
            {
                number = long.Parse(commandArgs[0]);
                name = commandArgs[1];
            }
            catch (Exception)
            {
                name = commandArgs[0];
                number = long.Parse(commandArgs[1]);
            }

            phonebook.Add(name, number);
            input = Console.ReadLine();
        }

        foreach (var name in phonebook)
        {
            Console.WriteLine($"{name.Key} -> {name.Value}");
        }
    }
}

