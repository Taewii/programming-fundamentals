using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, int>> nameLog = new Dictionary<string, Dictionary<string, int>>();
        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] splitInput = input.Split(' ');
            string name = splitInput[2].Substring(5);
            string ip = splitInput[0].Substring(3);

            if (!nameLog.ContainsKey(name))
            {
                nameLog.Add(name, new Dictionary<string, int>());
                nameLog[name].Add(ip, 1);
            }
            else
            {
                if (nameLog[name].ContainsKey(ip))
                {
                    nameLog[name][ip] = nameLog[name][ip] + 1;
                }
                else
                {
                    nameLog[name].Add(ip, 1);
                }
            }
            input = Console.ReadLine();
        }

        foreach (var item in nameLog.OrderBy(x => x.Key))
        {
            Console.WriteLine(item.Key + ":");

            StringBuilder sb = new StringBuilder();
            foreach (var ipAndCount in item.Value)
            {
                sb.Append(ipAndCount.Key).Append(" => ").Append(ipAndCount.Value + ", ");
            }

            sb.Remove(sb.Length - 2, 2);
            sb.Append(".");
            Console.WriteLine(sb.ToString());
        }
    }
}

