using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine().ToLower();
        string control = Console.ReadLine().ToLower();

        int index = -1; 
        int counter = 0;

        while (true)
        {        
            index = input.IndexOf(control, index + 1);
            if (index == -1)
            {
                break;
            }
            counter++;
        }

        Console.WriteLine(counter);
    }
}

