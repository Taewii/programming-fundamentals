using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        string[] idk = Console.ReadLine().Split();

        idk = idk.OrderBy(x => x).ToArray();

        Console.WriteLine(string.Join(", ", idk));
    }
}

