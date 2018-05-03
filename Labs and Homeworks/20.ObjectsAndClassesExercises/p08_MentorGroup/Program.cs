using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        while (input != "end of dates")
        {
            string[] commandArgs = input.Split(' ', ',');
            string name = commandArgs[0];
            string[] datess = commandArgs.Skip(1).ToArray();

            
        }
        Console.WriteLine();
    }
}

class Student
{
    public string Name { get; set; }

    public List<string> Comments { get; set; }

    public List<DateTime> Dates { get; set; }
}

