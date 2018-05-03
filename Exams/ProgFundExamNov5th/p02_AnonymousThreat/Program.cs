using System;
using System.Collections.Generic;
using System.Linq;

class p02_AnonymousThreat
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split().ToList();

        string inputCommands;
        while ((inputCommands = Console.ReadLine()) != "3:1")
        {
            string[] commandArgs = inputCommands.Split();
            string command = commandArgs[0];

            switch (command)
            {
                case "merge":
                    int start = int.Parse(commandArgs[1]);
                    int end = int.Parse(commandArgs[2]);
                    start = ValidateIndex(start, input.Count);
                    end = ValidateIndex(end, input.Count);

                    string concat = "";

                    for (int i = start; i <= end; i++)
                    {
                        concat += input[i];
                    }

                    for (int i = start; i <= end; i++)
                    {
                        input.RemoveAt(start);
                    }

                    input.Insert(start, concat);

                    break;
                case "divide":
                    int index = int.Parse(commandArgs[1]);
                    int partitions = int.Parse(commandArgs[2]);

                    List<string> result = Divided(input[index], partitions);
                    input.RemoveAt(index);
                    input.InsertRange(index, result);

                    break;
            }
        }
        Console.WriteLine(string.Join(" ", input));
    }

    private static List<string> Divided(string word, int partitions)
    {
        List<string> result = new List<string>();

        int parts = word.Length / partitions;

        while (word.Length >= parts)
        {
            result.Add(word.Substring(0, parts));
            word = word.Substring(parts);
        }

        if (word != "")
        {
            result.Add(word);
        }

        if (result.Count == partitions)
        {
            return result;
        }
        else
        {
            string lastTwo = result[result.Count - 2] + result[result.Count - 1];
            result.RemoveRange(result.Count - 2, 2);
            result.Add(lastTwo);
            return result;
        }
    }

    private static int ValidateIndex(int index, int count)
    {
        if (index < 0)
        {
            index = 0;
        }
        else if (index > count - 1)
        {
            index = count - 1;
        }
        return index;
    }
}

