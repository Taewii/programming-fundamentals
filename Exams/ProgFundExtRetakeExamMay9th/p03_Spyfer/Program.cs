using System;
using System.Collections.Generic;
using System.Linq;

class p03_Spyfer
{
    static void Main() 
    {
        List<int> seq = Console.ReadLine().Split().Select(int.Parse).ToList();

        for (int i = 0; i < seq.Count; i++)
        {
            if (i > 0 && i < seq.Count - 1)
            {
                if (seq[i] == seq[i - 1] + seq[i + 1])
                {
                    seq.RemoveAt(i + 1);
                    seq.RemoveAt(i - 1);
                    i = 0;
                }
            }
            else if (i == 0)
            {
                if (seq[i] == seq[i + 1])
                {
                    seq.RemoveAt(i + 1);
                    i = 0;
                }
            }
            else if (i == seq.Count - 1)
            {
                if (seq[i] == seq[i - 1])
                {
                    seq.RemoveAt(i - 1);
                    i = 0;
                }
            }
        }

        Console.WriteLine(string.Join(" ", seq));
    }
}
