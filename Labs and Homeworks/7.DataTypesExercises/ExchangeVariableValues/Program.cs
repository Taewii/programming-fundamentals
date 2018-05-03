using System;


class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");
        int c = a;
        a = b;
        b = c;
        Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");

        // Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");
        // Console.WriteLine($"After:\r\na = {b}\r\nb = {a}");
    }
}

