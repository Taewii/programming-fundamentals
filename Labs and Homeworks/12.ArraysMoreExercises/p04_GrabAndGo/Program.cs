using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int[] arrayNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        long sum = 0;

        bool isTrue = false;

        for (int pos = arrayNumbers.Length - 1; pos >= 0; pos--)
        {
            if (arrayNumbers[pos] == n)
            {
                isTrue = true;
                for (int i = 0; i < pos; i++)
                {
                    sum += arrayNumbers[i];
                }
                break;
            }
        }

        if (isTrue == false)
        {
            Console.WriteLine("No occurrences were found!");
        }
        else
        {
            Console.WriteLine(sum);
        }
    }
}
