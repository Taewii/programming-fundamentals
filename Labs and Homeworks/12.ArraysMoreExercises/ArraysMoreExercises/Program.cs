using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int max = numbers.Max();
        int min = numbers.Min();
        int sum = numbers.Sum();
        double average = numbers.Average();

        Console.WriteLine($"Min = {min}");
        Console.WriteLine($"Max = {max}");
        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Average = {average}");
    }
}

