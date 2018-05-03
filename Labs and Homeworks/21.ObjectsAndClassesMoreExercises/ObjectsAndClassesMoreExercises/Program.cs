using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        List<Person> people = new List<Person>();

        while (input != "End")
        {
            string[] commandArgs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Person person = new Person();
            person.Name = commandArgs[0];
            person.Id = commandArgs[1];
            person.Age = int.Parse(commandArgs[2]);

            people.Add(person);

            input = Console.ReadLine();
        }

        foreach (var person in people.OrderBy(x => x.Age))
        {
            Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
        }
    }
}

class Person
{
    public string Name { get; set; }

    public string Id { get; set; }

    public int Age { get; set; }
}

