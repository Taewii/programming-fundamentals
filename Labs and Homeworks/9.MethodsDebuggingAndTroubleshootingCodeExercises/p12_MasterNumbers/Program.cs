using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (IsPalindrome(i) && ContainsEvenDigit(i) && SumOfDigits(i) % 7 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPalindrome(int num)
    {
        int number = num;
        int reverse = 0;

        while (num > 0)
        {
            int lastDigit = num % 10;
            reverse = reverse * 10 + lastDigit;

            num /= 10;
        }
        if (number == reverse)
        {
            return true;
        }
        else
        {
            return false;
        }      
    }

    static int SumOfDigits(int num)
    {
        int lastDigit = 0;
        int sum = 0;

        while (num > 0)
        {
            lastDigit = num % 10;
            num = num / 10;
            sum += lastDigit;
        }
        return sum;
    }

    static bool ContainsEvenDigit(int num)
    {
        int lastDigit = 0;
        bool isEven = true;

        while (num > 0)
        {
            lastDigit = num % 10;
            num = num / 10;

            if (lastDigit % 2 == 0)
            {
                isEven = true;
                break;
            }
            else
            {
                isEven = false;
            }
        }

        if (isEven)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

