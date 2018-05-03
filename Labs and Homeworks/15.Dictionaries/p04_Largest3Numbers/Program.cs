using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        int[] result = numbers.OrderByDescending(x => x).Take(3).ToArray();
        Console.WriteLine(string.Join(" ", result));
    }
}

