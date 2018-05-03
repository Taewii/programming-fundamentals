using System;


class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double result = (a * b) / 1000000;

        Console.WriteLine($"{a}x{b} => {Math.Round(result, 1)}MP");
    }
}

