using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ');

       // var reverse = input.Reverse();

        //Console.WriteLine(string.Join(' ', reverse));

        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write($"{input[i] + " "}");
        }
    }
}

