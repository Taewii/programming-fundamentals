using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] inputToChars = input.ToCharArray();
        Dictionary<char, int> idk = new Dictionary<char, int>();

        int count = 1;

        foreach (var character in inputToChars)
        {
            if (!idk.ContainsKey(character))
            {
                idk.Add(character, count);
            }
            else
            {
                idk[character]++;
            }
        }

        foreach (var item in idk)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

