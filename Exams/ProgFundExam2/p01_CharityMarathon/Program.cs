using System;
using System.Numerics;

class p01_CharityMarathon
{
    static void Main()
    {
        BigInteger dayCount = BigInteger.Parse(Console.ReadLine());
        BigInteger runnerCount = BigInteger.Parse(Console.ReadLine());
        BigInteger averageLaps = BigInteger.Parse(Console.ReadLine());
        BigInteger lapLength = BigInteger.Parse(Console.ReadLine());
        BigInteger trackCapacity = BigInteger.Parse(Console.ReadLine());
        decimal moneyPerKm = decimal.Parse(Console.ReadLine());

        BigInteger totalRunners = 0;
        BigInteger maxCapacity = trackCapacity * dayCount;

        if (maxCapacity <= runnerCount)
        {
            totalRunners = maxCapacity;
        }
        else
        {
            totalRunners = runnerCount;
        }

        BigInteger totalMeters = totalRunners * averageLaps * lapLength;
        decimal totalKm = (decimal)totalMeters / 1000;
        decimal moneyRaised = totalKm * moneyPerKm;

        Console.WriteLine($"Money raised: {moneyRaised:f2}");
    }
}

