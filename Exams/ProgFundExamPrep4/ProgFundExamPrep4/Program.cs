using System;

class p01_SweetDessert
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        long guests = int.Parse(Console.ReadLine());
        double bananasPrice = double.Parse(Console.ReadLine());
        double eggsPrice = double.Parse(Console.ReadLine());
        double berriesPrice = double.Parse(Console.ReadLine());

        double portions = Math.Ceiling(guests / 6d);

        double result = portions * (2 * bananasPrice) + portions * (4 * eggsPrice) + portions * (0.2 * berriesPrice);

        if (result <= budget)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {result:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {result - budget:f2}lv more.");
        }
    }
}

