using System;


class Program
{
    static void Main(string[] args)
    {
        char n = char.Parse(Console.ReadLine());

        if (n == 'a' || n == 'e' || n == 'i' || n == 'o' || n == 'u')
        {
            Console.WriteLine("vowel");
        }
        else if (char.IsNumber(n))
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}

