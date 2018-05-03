using System;


class p01_Pokemon
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        decimal half = n / 2;

        int count = 0;

        while (true)
        {
            n -= m;
            count++;

            if (y != 0)
            {
                if (n == half && n / y > 0)
                {
                    n = n / y;
                }
            }

            if (n < m)
            {
                break;
            }
        }

        Console.WriteLine(Math.Floor(n));
        Console.WriteLine(count);
    }
}

