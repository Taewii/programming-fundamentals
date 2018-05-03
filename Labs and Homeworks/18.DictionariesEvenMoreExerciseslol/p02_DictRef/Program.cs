using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)   // 60/100
    {
        string input = Console.ReadLine(); 
        Dictionary<string, string> dict = new Dictionary<string, string>();

        while (input != "end")
        {
            string[] commands = input.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = commands[0];
            string value = commands[1];

            if (!dict.ContainsKey(name))
            {        
                if (dict.ContainsKey(value))
                {
                    dict[name] = dict[value];
                }
                else
                {
                    char[] valueToChar = value.ToCharArray();
                    if (char.IsDigit(valueToChar[0]))
                    {
                    dict.Add(name, value);
                    }
                }
            }
            else
            {
                if (!dict.ContainsKey(value))
                {
                    dict[name] = value;
                }
                else
                {
                    dict[name] = dict[value];
                }
            }
             
            input = Console.ReadLine();
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} === {item.Value}");
        }
    }
}

