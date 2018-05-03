using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int k = numbers.Length / 4;

        int[] leftArr = numbers.Take(k).Reverse().ToArray();
        int[] midArr = numbers.Skip(k).Take(2 * k).ToArray();
        int[] rightArr = numbers.Skip(3 * k).Reverse().ToArray();

        int[] leftAndRight = leftArr.Concat(rightArr).ToArray();
        var result = leftAndRight.Select((x, index) => x + midArr[index]);
        Console.WriteLine(string.Join(" ", result));
    }
}

