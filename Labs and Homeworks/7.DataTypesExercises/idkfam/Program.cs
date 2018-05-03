using System;


class Program
{
    static void Main(string[] args)
    {
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        string finalString = "";

        for (int i = 0; i < n; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            char toChar = (char)(letter + key);
            finalString += toChar;
        }
        Console.WriteLine(finalString);
    }
}

