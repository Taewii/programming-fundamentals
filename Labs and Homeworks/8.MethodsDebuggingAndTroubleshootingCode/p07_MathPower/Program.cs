using System;


class Program
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double result = PowerOfNumber(n, p);
        Console.WriteLine(result);

    }

    static double PowerOfNumber (double n, double p)
    {
        double number = 1;
        
        for (double i = 1; i <= p; i++)
        {
            number *= n;
        }
        return number;
    }
}

