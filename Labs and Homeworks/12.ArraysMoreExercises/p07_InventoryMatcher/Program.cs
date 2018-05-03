using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine().Split().ToArray();
        long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
        decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        string commands = "";

        while (commands != "done")
        {
            commands = Console.ReadLine();
            if (commands != "done")
            {
                int index = Array.IndexOf(names, commands);
                Console.WriteLine($"{commands} costs: {prices[index]}; Available quantity: {quantities[index]}");
            }
        }
    }
}

