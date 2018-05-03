using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] badWords = Console.ReadLine().Split(' ', ',').Where(w => w.Length > 0).ToArray();
        string text = Console.ReadLine();

        foreach (var badWord in badWords)
        {
            text = text.Replace(badWord, new string('*', badWord.Length));
        }

        Console.WriteLine(text);
    }
}

