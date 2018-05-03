using System;


class Program
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        var a = 0;

        try
        {
            a = int.Parse(number);
            Console.WriteLine("It is a number.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");            
        }
    }
}

