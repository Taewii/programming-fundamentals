using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int last = 0;
        int first = 0;   
        bool trueOrFalse = false;

        for (int i = 1; i <= n; i++)
        {
            first = i;
            while (i > 0)
            {
                last += i % 10;
                i = i / 10;
            }
            trueOrFalse = (last == 5) || (last == 7) || (last == 11);
            Console.WriteLine($"{first} -> {trueOrFalse}");
            last = 0;
            i = first;
        }

    }
}

