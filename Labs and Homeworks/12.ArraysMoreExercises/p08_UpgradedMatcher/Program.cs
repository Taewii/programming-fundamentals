using System;
using System.Linq;

class Program
{
    static void Main(string[] args) // not workin properly, forgot the score in judge but it aint 100 lol
    {
        string[] names = Console.ReadLine().Split().ToArray();
        long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
        decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        string commands = "";

        while (commands != "done")
        {
            commands = Console.ReadLine();
            string[] orders = commands.Split().ToArray();

            if (commands == "done")
            {
                break;
            }

            int index = Array.IndexOf(names, orders[0]);

            long orderLong = long.Parse(orders[1]);
            decimal priceDecimal = prices[index];
            long neededQuantity = int.Parse(orders[1]);

            if (index > quantities.Length - 1)
            {
                Console.WriteLine($"We do not have enough {names[index]}");
            }
            else
            {
                quantities[index] -= orderLong;
                if (quantities[index] < 0)
                {
                    Console.WriteLine($"We do not have enough {names[index]}");
                }
                else
                {
                    Console.WriteLine($"{names[index]} x {orderLong} costs {orderLong * priceDecimal:f2}");
                }
            }
        }
    }
}

