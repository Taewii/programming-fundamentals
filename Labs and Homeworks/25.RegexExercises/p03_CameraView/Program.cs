using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)   //66/100 nigga it dont work
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<string> input = Console.ReadLine().Split('|').ToList();
        List<string> result = new List<string>();

        foreach (var item in input)   
        {
            if (item.Length < numbers[0] + numbers[1])
            {
                continue;
            }
            if (item.Contains("<"))
            {
                char[] ad = item.Skip(numbers[0] + 1).Take(numbers[1]).ToArray();

                string toString = "";
                for (int i = 0; i < ad.Length; i++)
                {
                    toString += ad[i];
                }
                result.Add(toString);
            }
        }
        Console.WriteLine(string.Join(", ", result));
    }
}

