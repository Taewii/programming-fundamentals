using System;
using System.Numerics;


class Program
{
    static void Main(string[] args)
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (BigInteger i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        int zeroes = 0;

        while (factorial % 10 == 0)
        {
            zeroes++;
            factorial = factorial / 10;
        }
        Console.WriteLine(zeroes);
    }
}

