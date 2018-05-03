using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> words = Console.ReadLine()
            .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, 
            StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<string> lowerCase = new List<string>();
        List<string> upperCase = new List<string>();
        List<string> mixedCase = new List<string>();

        for (int i = 0; i < words.Count; i++)
        {
            if (IsUpper(words[i]))
            {
                upperCase.Add(words[i]);
            }
            else if (IsLower(words[i]))
            {
                lowerCase.Add(words[i]);
            }
            else
            {
                mixedCase.Add(words[i]);
            }
        }
        Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
    }

    static bool IsUpper(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (!Char.IsUpper(input[i]))
                return false;
        }
        return true;
    }

    static bool IsLower(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (!Char.IsLower(input[i]))
                return false;
        }
        return true;
    }
}

