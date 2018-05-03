using System;
using System.Collections.Generic;
using System.Linq;

class p02_Ladybugs
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        List<int> indexes = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(i => i >= 0 && i < size)
            .ToList();

        int[] field = new int[size];
        for (int i = 0; i < indexes.Count; i++)
        {
            field[indexes[i]] = 1;
        }

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int index = int.Parse(tokens[0]);
            string direction = tokens[1];
            int flyLength = int.Parse(tokens[2]);

            if (direction == "left")
            {
                flyLength *= -1;
            }

            if (index < 0 || index >= size)
            {
                continue;
            }

            if (field[index] == 0)
            {
                continue;
            }

            field[index] = 0;

            int nextIndexToLand = index;

            while (true)
            {
                nextIndexToLand += flyLength;

                if (nextIndexToLand < 0 || nextIndexToLand >= size)
                {
                    break;
                }

                if (field[nextIndexToLand] == 1)
                {
                    continue;
                }

                field[nextIndexToLand] = 1;
                break;
            }
        }
        Console.WriteLine(string.Join(" ", field));
    }
}

