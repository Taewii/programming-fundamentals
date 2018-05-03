using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> chars = Console.ReadLine().Split().Where(x => x.Length == 2).Reverse().ToList();

        for (int i = 0; i < chars.Count; i++)
        {
            string reversedNum = new string(chars[i].ToCharArray().Reverse().ToArray());
            chars[i] = reversedNum;
        }
        Console.WriteLine();
    }
}

