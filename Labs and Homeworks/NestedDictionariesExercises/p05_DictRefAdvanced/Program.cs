using System;
using System.Collections.Generic;

namespace Dict_Ref_Advanced
{
    public class DictRefAdvanced
    {
        public static void Main()
        {
            Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParams = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string currentKey = inputParams[0];
                int firstValue = -1;

                if (int.TryParse(inputParams[1], out firstValue))
                {
                    if (!dictionary.ContainsKey(currentKey))
                    {
                        dictionary[currentKey] = new List<int>();
                    }

                    for (int i = 1; i < inputParams.Length; i++)
                    {
                        dictionary[currentKey].Add(int.Parse(inputParams[i]));
                    }
                }
                else
                {
                    string otherKey = inputParams[1];
                    if (dictionary.ContainsKey(otherKey))
                    {
                        dictionary[currentKey] = new List<int>(dictionary[otherKey]);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var entry in dictionary)
            {
                Console.WriteLine($"{entry.Key} === " + string.Join(", ", entry.Value));
            }
        }
    }
}