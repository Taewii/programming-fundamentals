using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> bombArgs = Console.ReadLine().Split().Select(int.Parse).ToList();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bombArgs[0])
            {
                for (int j = i - bombArgs[1]; j <= bombArgs[1] + i; j++)
                {
                    if (j >= 0 && j <= numbers.Count - 1)
                    {
                        numbers[j] = 0;
                    }
                }
            }
        }
        Console.WriteLine(numbers.Sum());
    }
}

