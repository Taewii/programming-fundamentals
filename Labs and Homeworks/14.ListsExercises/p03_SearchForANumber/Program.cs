using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<int> numbersLeft = new List<int>();

        numbersLeft = list.Take(commands[0]).ToList();
        numbersLeft.RemoveRange(0, commands[1]);
        numbersLeft.Find(item => item == commands[2]);

        if (numbersLeft.Find(item => item == commands[2]) > 0)
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }
    }
}

