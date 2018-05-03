using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)  // no clue fam
    {
        Dictionary<string, int> farm = new Dictionary<string, int>();
       
        int materialCount = 0;

        while (true)
        {
            string input = Console.ReadLine().ToLower();
            string[] fragmets = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
           
            foreach (var material in fragmets)
            {
                try
                {
                    materialCount = int.Parse(material);
                    continue;
                }
                catch (Exception)
                {
                    if (!farm.ContainsKey(material))
                    {
                        farm.Add(material, materialCount);
                    }
                    else
                    {
                        farm[material] = farm[material] + materialCount;
                    }

                    if (farm.Values.Equals("fragments").Equals(250) || farm.Values.Equals("shards").Equals(250) || farm.Values.Equals("motes").Equals(250))
                    {
                        break;
                    }
                }
            }   
        }
        Console.WriteLine();


    }
}

