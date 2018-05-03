using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Console.ReadLine()
            .Split()
            .Select(a => int.Parse(new string(a.Reverse().ToArray())))
            .Sum());
    }
}

