using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        HashSet<string> palindromes = new HashSet<string>();
        foreach (var word in text)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }   
     
        Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
    }

    static bool IsPalindrome(string word)
    {
        string reversed = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversed += word[i];
        }

        if (word == reversed)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

