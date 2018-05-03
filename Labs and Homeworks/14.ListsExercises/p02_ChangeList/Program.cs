using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        string command = Console.ReadLine();

        int[] actions = command.Split().Skip(1).Select(int.Parse).ToArray();

        while (command != "Odd" && command != "Even")
        {
            if (command.Contains("Delete"))
            {             
               list.RemoveAll(item => item == actions[0]);
            }
            else if (command.Contains("Insert"))
            {
                list.Insert(actions[1], actions[0]);
            }
            command = Console.ReadLine();
        }

        if (command == "Even")
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    Console.Write(list[i] + " ");
                }
            }
        }
        else
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 1)
                {
                    Console.Write(list[i] + " ");
                }
            }
        }
    }
}

