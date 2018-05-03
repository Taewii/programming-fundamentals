using System;


class Program
{
    static void Main(string[] args)
    {
        double fahrenheit = double.Parse(Console.ReadLine());
        FahrenheitToCelsius(fahrenheit);
    }

    static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{celsius:f2}");
    }
}

