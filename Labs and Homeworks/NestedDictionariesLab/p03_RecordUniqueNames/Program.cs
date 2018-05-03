using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> names = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            names.Add(input);
        }

        Console.WriteLine(string.Join("\r\n", names));

       // int n = int.parse(console.readline());
       // list<string> names = new list<string>();
       //
       // for (int i = 0; i < n; i++)                           this also works with .Distinct();
       // {
       //     string input = console.readline();
       //     names.add(input);
       // }
       //
       // var result = names.distinct();
       // console.writeline(string.join("\r\n", result));
    }
}

