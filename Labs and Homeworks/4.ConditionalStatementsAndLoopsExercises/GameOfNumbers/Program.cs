using System;


class Program
{
    static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int magic = int.Parse(Console.ReadLine());

        int counter = 0;

        int a = 0;
        int b = 0;

        for (int i = first; i <= second; i++)
        {
            counter++;
            for (int j = first; j < second; j++)
            {
                counter++;
                if (i + j == magic)
                {
                    a = i;
                    b = j;
                }
            }
        }

        if (a + b == magic)
        {
            Console.WriteLine($"Number found! {a} + {b} = {magic}");
        }
        else
        {
            Console.WriteLine($"{counter} combinations - neither equals {magic}");
        }
    }
}

