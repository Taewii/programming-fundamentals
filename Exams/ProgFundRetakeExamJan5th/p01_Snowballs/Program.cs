using System;
using System.Numerics;

class p01_Snowballs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int bestSnow = 0;
        int bestTime = 0;
        BigInteger bestValue = -1;
        int bestQuality = 0;

        for (int i = 0; i < n; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

            if (snowballValue >= bestValue)
            {
                bestSnow = snowballSnow;
                bestTime = snowballTime;
                bestValue = snowballValue;
                bestQuality = snowballQuality;
            }
        }
        Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
    }
}

