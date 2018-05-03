using System;


class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int numberItems = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 0; i < numberItems; i++)
        {
            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            double count = double.Parse(Console.ReadLine());

            sum += count * price;
            if (count > 1)
            {
                Console.WriteLine($"Adding {count} {name}s to cart.");
            }
            else
            {
                Console.WriteLine($"Adding {count} {name} to cart.");
            }
        }

        if (budget >= sum)
        {
            Console.WriteLine($"Subtotal: ${sum:F2}\r\nMoney left: ${budget - sum:F2}");
        }
        else
        {
            Console.WriteLine($"Subtotal: ${sum:F2}\r\nNot enough. We need ${sum - budget:F2} more.");
        }
    }
}

