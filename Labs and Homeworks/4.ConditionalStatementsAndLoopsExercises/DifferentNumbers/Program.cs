using System;


class Program
{
    static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int a = first; a <= second; a++)
        {
            for (int b = first; b <= second; b++)
            {
                for (int c = first; c <= second; c++)
                {
                    for (int d = first; d <= second; d++)
                    {
                        for (int e = first; e <= second; e++)
                        {
                            if (first <= a && a < b && b < c && c < d && d < e && d <= second)
                            {
                                Console.WriteLine($"{a} {b} {c} {d} {e}");
                                counter++;
                            }
                        }
                    }
                }
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
}

