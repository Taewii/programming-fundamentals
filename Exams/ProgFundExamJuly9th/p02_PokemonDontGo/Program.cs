using System;
using System.Collections.Generic;
using System.Linq;

class p02_PokemonDontGo
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        int sum = 0;
        int removed = 0;

        while (numbers.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());

            if (index < 0)
            {
                removed = numbers[0];
                numbers[0] = numbers[numbers.Count - 1];
            }
            else if (index > numbers.Count - 1)
            {
                removed = numbers[numbers.Count - 1];
                numbers[numbers.Count - 1] = numbers[0];
            }
            else
            {
                removed = numbers[index];
                numbers.RemoveAt(index);
            }

            sum += removed;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= removed)
                {
                    numbers[i] += removed;
                }
                else
                {
                    numbers[i] -= removed;
                }
            }
        }
        Console.WriteLine(sum);
    }
}

