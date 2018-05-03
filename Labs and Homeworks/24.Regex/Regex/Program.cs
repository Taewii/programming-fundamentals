using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";
        string input = Console.ReadLine();

        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.Write(m.Value + " ");
        }
    }
}