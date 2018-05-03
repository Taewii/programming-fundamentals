using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool isSum = false;

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                int sum = input[i] + input[j];

                if (input.Contains(sum))
                {
                    Console.WriteLine($"{input[i]} + {input[j]} == {sum}");
                    isSum = true;
                }
            }
        }

        if (!isSum)
        {
            Console.WriteLine("No");
        }
    }
}

