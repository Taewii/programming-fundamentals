using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool isSum = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            int[] leftSide = numbers.Take(i).ToArray();
            int[] rightSide = numbers.Skip(i + 1).ToArray();

            if (leftSide.Sum() == rightSide.Sum())
            {
                Console.WriteLine(i);
                isSum = true;
            }
        }

        if (!isSum)
        {
            Console.WriteLine("no");
        }
    }
}

