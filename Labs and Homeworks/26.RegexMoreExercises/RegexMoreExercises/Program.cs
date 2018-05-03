using System;

class Program
{
    static void Main(string[] args)
    {
        string control = Console.ReadLine();
        string text = Console.ReadLine();

        string result = text.Replace(control, new string('*', control.Length));
        Console.WriteLine(result);
    }
}

