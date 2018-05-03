using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            PrintTriangle(i);
            Console.WriteLine();
        }

        for (int i = n; i >= 1; i--)
        {
            PrintTriangle(i);
            Console.WriteLine();
        }
    }

    static void PrintTriangle (int number)
    {
        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
        }
    }
}

