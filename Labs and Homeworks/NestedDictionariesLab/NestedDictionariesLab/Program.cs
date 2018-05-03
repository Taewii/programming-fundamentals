using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<double>> gradeBook = new Dictionary<string, List<double>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            double grade = double.Parse(input[1]);

            if (!gradeBook.ContainsKey(name))
            {
                gradeBook.Add(name, new List<double>());
                gradeBook[name].Add(grade);
            }
            else
            {
                gradeBook[name].Add(grade);
            }
        }
        //           prob fucks up cuz idk how to format ":f2" in a string.Join. still 100/100 with the one below tho.
        //
        // foreach (var person in gradeBook)        
        // {
        //     Console.WriteLine($"{person.Key} -> {string.Join(" ", person.Value)} (avg: {person.Value.Average():f2})");
        // }

        foreach (var name in gradeBook)
        {
            Console.Write($"{name.Key} -> ");

            foreach (double grade in name.Value)
            {
                Console.Write($"{grade:f2} ");
            }
            Console.WriteLine($"(avg: {name.Value.Average():f2})");

        }
    }
}

