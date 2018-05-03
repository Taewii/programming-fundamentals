using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>(); 

        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            numbers.Add(currentNum);
        }

        Console.WriteLine($"Sum = {numbers.Sum()}");
        Console.WriteLine($"Min = {numbers.Min()}");
        Console.WriteLine($"Max = {numbers.Max()}");
        Console.WriteLine($"Average = {numbers.Average()}");
    }
}

