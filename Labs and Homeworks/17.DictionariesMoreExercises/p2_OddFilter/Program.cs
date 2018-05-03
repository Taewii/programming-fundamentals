using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        numbers = numbers.Where(x => x % 2 == 0).ToArray();

        double average = numbers.Average();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > average)
            {
                numbers[i]++;
            }
            else
            {
                numbers[i]--;
            }
        }
        Console.WriteLine(string.Join(", ", numbers));
    }
}

