using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"\b(?<!\S)[a-z][a-z0-9\.\-_]+[a-z0-9]*@[a-z][a-z\-]+\.[a-z][a-z\.]+[a-z]?\b";
        string input = Console.ReadLine();

        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.WriteLine(m.Value);
        }
    }
}