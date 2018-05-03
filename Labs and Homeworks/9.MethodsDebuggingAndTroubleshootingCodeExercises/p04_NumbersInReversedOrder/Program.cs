using System;


class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string result = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            result += input[i];
        }
        Console.WriteLine(result);
    }
}

