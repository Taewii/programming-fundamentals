using System;


class Program
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());
        
        if (isPrime(number))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }

    public static bool isPrime(long number)
    {
        for (int k = 2; k <= Math.Ceiling(Math.Sqrt(number)); k++)
        {
            if (number > k && number % k == 0)
                break;
            if (k >= Math.Ceiling(Math.Sqrt(number)) || number == k)
            {
                return true;
            }
        }
        return false;
    }
}


