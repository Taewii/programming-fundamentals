using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<double>> database = new Dictionary<string, List<double>>();
        string input = Console.ReadLine();

        while (input != "stocked")
        {
            string[] commandArgs = input.Split();
            string product = commandArgs[0];
            double price = double.Parse(commandArgs[1]);
            int quantity = int.Parse(commandArgs[2]);

            if (!database.ContainsKey(product))
            {
                database[product] = new List<double>();
                database[product].Add(0);
                database[product].Add(0);
            }

            database[product][0] = price;
            database[product][1] += quantity;

            input = Console.ReadLine();
        }

        double totalAll = 0;
        foreach (var item in database)
        {
            double total = item.Value[0] * item.Value[1];
            totalAll += total;
            Console.WriteLine($"{item.Key}: ${item.Value[0]:f2} * {item.Value[1]} = ${total:f2} ");
        }
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${totalAll:f2}");
    }
}

