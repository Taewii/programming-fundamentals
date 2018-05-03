using System;


class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int result = GetMax(a, b);

        if (result > c)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(c);
        }
    }

    static int GetMax (int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }       
    }
}

