using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        TopAndBottomRow(n);
        Middle(n);
        TopAndBottomRow(n);
    }

    static void TopAndBottomRow(int n)
    {
        Console.WriteLine(new string('-', n * 2));
    }

    static void Middle(int n)
    {
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write('-');
            for (int j = 0; j < n - 1 ; j++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
    }
}

