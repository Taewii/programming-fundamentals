using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        { 
            for (int h = 0; h < i; h++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

