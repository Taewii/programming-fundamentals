using System;
using System.Linq;

class Program
{
    static void Main(string[] args) 
    {
        int[] arr = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int k = arr.Length / 4;

        int[] leftArr = arr.Take(k).ToArray();
        int[] midArr = arr.Skip(k).Take(k * 2).ToArray();
        int[] rightArr = arr.Skip(k * 3).Take(k).ToArray();

        Array.Reverse(leftArr);
        Array.Reverse(rightArr);

        int[] result = new int[k * 2];
        for (int i = 0; i < k; i++)
        {
            result[i] = midArr[i] + leftArr[i];
            result[i + k] = midArr[i + k] + rightArr[i];
        }

        Console.WriteLine($"{string.Join(" ", result)}");
    }
}

