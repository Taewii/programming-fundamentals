using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] number1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] number2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        int len1 = number1.Length;
        int len2 = number2.Length;
        int max = Math.Max(len1, len2);

        for (int i = 0; i < max; i++)
        {
        int firstValue = number1[i % number1.Length];
        int secondValue = number2[i % number2.Length];
        Console.Write($"{firstValue + secondValue} ");
        }
    }
}

