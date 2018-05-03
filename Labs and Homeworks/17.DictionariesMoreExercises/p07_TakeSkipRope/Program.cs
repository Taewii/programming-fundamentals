using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string startingString = Console.ReadLine();
        char[] stringToChars = startingString.ToCharArray();

        List<int> numbers = new List<int>();
        List<char> chars = new List<char>();

        foreach (var character in stringToChars)
        {
            if (char.IsDigit(character))
            {
                numbers.Add(character - 48);
            }
            else
            {
                chars.Add(character);
            }
        }

        List<int> take = new List<int>();
        List<int> skip = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (i % 2 == 0)
            {
                take.Add(numbers[i]);
            }
            else
            {
                skip.Add(numbers[i]);
            }
        }

        string final = "";
        int charsTaken = 0;
        for (int i = 0; i < take.Count; i++)
        {
            char[] result = chars.Skip(charsTaken).Take(take[i]).ToArray();
            charsTaken += skip[i] + take[i];

            for (int j = 0; j < result.Length; j++)
            {
                final += result[j];
            }
        }

        Console.WriteLine(final);
    }
}

