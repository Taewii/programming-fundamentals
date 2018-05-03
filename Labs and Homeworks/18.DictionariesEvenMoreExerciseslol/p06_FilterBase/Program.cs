using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Dictionary<string, int> dictAges = new Dictionary<string, int>();
        Dictionary<string, double> dictSalaries = new Dictionary<string, double>();
        Dictionary<string, string> dictPositions = new Dictionary<string, string>();

        while (input != "filter base")
        {
            string[] commandArgs = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string name = commandArgs[0];           
            int age;
            double salary;

            if (int.TryParse(commandArgs[1], out age))
            {
                dictAges.Add(name, age);
            }
            else if (double.TryParse(commandArgs[1], out salary))
            {
                dictSalaries.Add(name, salary);
            }
            else
            {
                dictPositions.Add(name, commandArgs[1]);
            }

            input = Console.ReadLine();
        }

        string filterBy = Console.ReadLine();

        if (filterBy == "Age")
        {
            foreach (var person in dictAges)
            {
                Console.WriteLine($"Name: {person.Key}");
                Console.WriteLine($"Age: {person.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }
        else if (filterBy == "Salary")
        {
            foreach (var person in dictSalaries)
            {
                Console.WriteLine($"Name: {person.Key}");
                Console.WriteLine($"Salary: {person.Value:f2}");
                Console.WriteLine(new string('=', 20));
            }
        }
        else if (filterBy == "Position")
        {
            foreach (var person in dictPositions)
            {
                Console.WriteLine($"Name: {person.Key}");
                Console.WriteLine($"Position: {person.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }
    }
}

