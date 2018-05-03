using System;


class Program
{
    static void Main(string[] args)
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());

        double difference = 0.000001;

        if (Math.Abs(first - second) < difference)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

