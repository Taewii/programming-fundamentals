using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
        List<int> result = new List<int>();

        bool isPositive = false;
        for (int i = numbers.Count; i > 0; i--)
        {
            if (numbers[i - 1] > 0)
            {
                result.Add(numbers[i - 1]);
                isPositive = true;
            }
        }
        if (!isPositive)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", result));
        }       
    }
}
