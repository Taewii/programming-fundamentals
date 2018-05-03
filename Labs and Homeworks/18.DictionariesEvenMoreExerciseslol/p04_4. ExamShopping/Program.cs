using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {        
        Dictionary<string, int> shop = new Dictionary<string, int>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "exam time")
            {
                break;
            }

            if (input == "shopping time")
            {
                continue;
            }

            string[] commandArgs = input.Split();
            string command = commandArgs[0];
            string product = commandArgs[1];
            int quantity = int.Parse(commandArgs[2]);

            if (command == "stock")
            {
                if (!shop.ContainsKey(product))
                {
                    shop.Add(product, quantity);
                }
                else
                {
                    shop[product] += quantity;
                }
            }
            else if (command == "buy")
            {
                if (!shop.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else if (shop[product] <= 0)
                {
                    Console.WriteLine($"{product} out of stock");
                }
                else if (shop[product] - quantity <= 0)
                {
                    shop[product] = 0;
                }
                else
                {
                    shop[product] -= quantity;
                }
            }
        }

        foreach (var item in shop)
        {
            if (item.Value > 0)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

