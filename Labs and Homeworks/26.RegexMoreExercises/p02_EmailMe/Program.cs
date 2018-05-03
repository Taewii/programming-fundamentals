using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split('@');
        char[] first = input[0].ToCharArray();
        char[] second = input[1].ToCharArray();

        int firstSum = 0;
        int secondSum = 0;

        for (int i = 0; i < first.Length; i++)
        {
            firstSum += first[i];
        }

        for (int i = 0; i < second.Length; i++)
        {
            secondSum += second[i];
        }

        int result = firstSum - secondSum;

        Console.WriteLine(result >= 0 ? "Call her!" : "She is not the one.");      
    }
}

