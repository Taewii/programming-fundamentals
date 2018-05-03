using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        File.WriteAllText("text.txt", "Pesho Gosho Ivan Kuro Idk");
        string text = File.ReadAllText("text.txt");
        Console.WriteLine(text);
    }
}

