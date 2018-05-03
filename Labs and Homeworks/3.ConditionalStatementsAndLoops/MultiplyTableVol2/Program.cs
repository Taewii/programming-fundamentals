using System;


class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        for (int i = b; i <= 10; i++)
        {
            Console.WriteLine("{0} X {1} = {2}", a, i, a * i);
        }

        if (b > 10)
        {
            Console.WriteLine("{0} X {1} = {2}", a, b, a * b);
        }
    }
}

