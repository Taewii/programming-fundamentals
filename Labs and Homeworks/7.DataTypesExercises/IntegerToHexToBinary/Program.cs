using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string toHex = Convert.ToString(n, 16).ToUpper();
        string toBinary = Convert.ToString(n, 2);

        Console.WriteLine(toHex);
        Console.WriteLine(toBinary);
    }
}

