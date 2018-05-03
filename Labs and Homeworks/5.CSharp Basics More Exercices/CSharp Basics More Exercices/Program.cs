using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++)
        {
            string top = new string(' ', i)
                + 'x'
                + new string(' ', n - 2 - i * 2)
                + 'x';

            Console.WriteLine(top);
        }

        Console.WriteLine(new string(' ', n / 2) + 'x');

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            string bot = new string(' ', i)
                + 'x'
                + new string(' ', n - 2 - i * 2)
                + 'x';

            Console.WriteLine(bot);
        }
    }
}

