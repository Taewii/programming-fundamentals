using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> words = Console.ReadLine()
            .ToLower()
            .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        
        var shortWords = words.Where(s => s.Length < 5);       
        var result = shortWords.OrderBy(x => x).Distinct();
        Console.WriteLine(string.Join(", ", result));
    }
}

