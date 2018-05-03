using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> list = new Dictionary<string, string>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] commandArgs = Console.ReadLine().Split();
            string command = commandArgs[0];
            string name = commandArgs[1];
            if (command == "register")
            {
                string plate = commandArgs[2];
                char[] plateToChar = plate.ToCharArray();

                bool isValid = true;

                if (plateToChar.Length > 8)
                {
                    isValid = false;
                }
                else if (!(char.IsUpper(plateToChar[0]) && char.IsUpper(plateToChar[1]) && char.IsUpper(plateToChar[6]) && char.IsUpper(plateToChar[7])))
                {
                    isValid = false;
                }
                else if (!(char.IsDigit(plateToChar[2]) && char.IsDigit(plateToChar[3]) && char.IsDigit(plateToChar[4]) && char.IsDigit(plateToChar[5])))
                {
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
                if (isValid == false)
                {
                    Console.WriteLine($"ERROR: invalid license plate {plate}");
                    continue;
                }

                if (!list.ContainsKey(name))
                {
                    if (list.ContainsValue(plate))
                    {
                        Console.WriteLine($"ERROR: license plate {plate} is busy");
                    }
                    else
                    {
                        list.Add(name, plate);
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }
                }
                else
                {
                    if (list.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {list[name]}");
                    }
                }
            }

            if (command == "unregister")
            {
                if (list.ContainsKey(name))
                {
                    Console.WriteLine($"user {name} unregistered successfully");
                    list.Remove(name);
                }
                else
                {
                    Console.WriteLine($"ERROR: user {name} not found");
                }
            }
        }

        foreach (var name in list)
        {
            Console.WriteLine($"{name.Key} => {name.Value}");
        }
    }
}

