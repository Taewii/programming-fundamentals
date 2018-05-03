using System;


class Program
{
    static void Main(string[] args)
    {
        int n = Math.Abs(int.Parse(Console.ReadLine()));

        int sumEvens = SumOfEvenDigits(n);
        int sumOdd = SumOfOddDigits(n);

        int result = sumEvens * sumOdd;
        Console.WriteLine(result);
    }

    static int SumOfEvenDigits (int n)
    {
        int sum = 0;
        int lastDigit = 0;

        while (n > 0)
        {
            lastDigit = n % 10;
            n = n / 10;

            if (lastDigit % 2 == 0)
            {
                sum += lastDigit;
            }
        }
        return sum;       
    }

    static int SumOfOddDigits (int n)
    {
        int sum = 0;
        int lastDigit = 0;

        while (n > 0)
        {
            lastDigit = n % 10;
            n = n / 10;

            if (lastDigit % 2 == 1)
            {
                sum += lastDigit;
            }
        }
        return sum;
    }
}

