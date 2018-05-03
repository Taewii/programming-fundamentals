using System;
using System.Linq;

class p02_Rainer
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] seq = input.Take(input.Length - 1).ToArray();
        int lastIndex = input.Last();

        int counter = 0;

        seq = seq.Select(x => x - 1).ToArray();

        while (true)
        {
            int index = int.Parse(Console.ReadLine());
            counter++;

            seq = seq.Select(x => x - 1).ToArray();

            if (seq[index] == 0)
            {
                break;
            }

            for (int i = 0; i < seq.Length; i++)
            {
                if (seq[i] == 0)
                {
                    seq[i] = input[i];
                }
            }
        }

        Console.WriteLine(string.Join(" ", seq));
        Console.WriteLine(counter);
    }
}

