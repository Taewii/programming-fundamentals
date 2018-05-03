using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
      
        for (int i = 1; i <= n; i++)
        {
            int firstI = i / 10;
            int last = i % 10;
            if (i == 5 || i == 7 || firstI + last == 7 || firstI + last == 5 || firstI + last == 11)
            {
                Console.WriteLine($"{i} -> True");
            }
            else
            {
                Console.WriteLine($"{i} -> False");
            }
        }
    }
}

