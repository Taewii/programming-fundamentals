using System;
using System.Linq;

class p01_Raindrops
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double density = double.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long raindropsCount = input[0];
            long squareMeters = input[1];

            double result = (double)raindropsCount / squareMeters;
            sum += result;
        }

        if (density == 0)
        {
            Console.WriteLine($"{sum:f3}");
        }
        else
        {
            double final = sum / density;
            Console.WriteLine($"{final:F3}");
        }
    }
}

