using System;

namespace MilesToKilometer
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            double result = miles * 1.60934;

            Console.WriteLine($"{result:f2}");
        }
    }
}
