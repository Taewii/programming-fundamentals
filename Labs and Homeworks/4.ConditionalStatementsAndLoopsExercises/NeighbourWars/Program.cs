using System;


class Program
{
    static void Main(string[] args)
    {
        int peshoDmg = int.Parse(Console.ReadLine());
        int goshoDmg = int.Parse(Console.ReadLine());

        int peshoHealth = 100;
        int goshoHealth = 100;
        int counter = 0;

        for (int i = 1; i < 1000; i++)
        {

            counter++;

            if (i % 2 != 0)
            {
                if (goshoHealth - peshoDmg <= 0)
                {
                    Console.WriteLine($"Pesho won in {counter}th round.");
                    return;
                }
                goshoHealth -= peshoDmg;
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
            }
            else
            {
                if (peshoHealth - goshoDmg <= 0)
                {
                    Console.WriteLine($"Gosho won in {counter}th round.");
                    return;
                }
                peshoHealth -= goshoDmg;
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
            }

            if (i % 3 == 0)
            {
                goshoHealth += 10;
                peshoHealth += 10;
            }
        }
    }
}

