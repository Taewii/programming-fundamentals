using System;
using System.Collections.Generic;
using System.Linq;

class p02_DrumSet
{
    static void Main()
    {
        double savings = double.Parse(Console.ReadLine());
        List<int> startingDrums = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> drums = new List<int>();

        for (int i = 0; i < startingDrums.Count; i++)
        {
            drums.Add(startingDrums[i]);
        }

        string input;
        while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
        {
            int hitPower = int.Parse(input);

            for (int i = 0; i < drums.Count; i++)
            {
                drums[i] -= hitPower;
            }

            for (int k = 0; k < drums.Count; k++)
            {
                if (drums[k] <= 0)
                {
                    int newDrumPrice = startingDrums[k] * 3;

                    if (savings >= newDrumPrice)
                    {
                        savings -= newDrumPrice;
                        drums[k] = startingDrums[k];
                    }
                    else
                    {
                        drums.RemoveAt(k);
                        startingDrums.RemoveAt(k);
                    }
                }
            }
        }

        Console.WriteLine(string.Join(" ", drums));
        Console.WriteLine($"Gabsy has {savings:f2}lv.");
    }
}