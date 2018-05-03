using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var num = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        for (int i = 0; i < num.Length; i++)
        {
            double rounding = Math.Round(num[i], 0, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{num[i]} => {rounding}");
        }
    }
}

