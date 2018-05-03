using System;
using System.Linq;

class p03_Wormhole
{
    static void Main()
    {
        int[] seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int steps = 0;

        for (int i = 0; i < seq.Length; i++)
        {
            if (seq[i] != 0)
            {
                int index = i;
                i = seq[i];
                seq[index] = 0;
            }
            steps++;
        }
        Console.WriteLine(steps);
    }
}