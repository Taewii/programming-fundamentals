using System;
using System.Collections.Generic;
using System.Linq;

class p03_EnduranceRally
{
    static void Main()   //60/100
    {
        string[] names = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double[] track = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();
        List<long> checkpointsStart = Console.ReadLine()
            .Split()
            .Select(long.Parse)
            .ToList();

        foreach (var name in names)
        {
            double energy = name.ToCharArray()[0];

            List<long> checkpoints = new List<long>();

            foreach (var cp in checkpointsStart)
            {
                checkpoints.Add(cp);
            }

            for (long i = 0; i < track.Length; i++)
            {

                if (checkpoints.Count != 0 && checkpoints[0] == i)
                {
                    energy += track[i];
                    checkpoints.RemoveAt(0);
                }
                else
                {
                    energy -= track[i];
                    if (energy <= 0)
                    {
                        Console.WriteLine($"{name} - reached {i}");
                        break;
                    }
                }
            }

            if (energy > 0)
            {
                Console.WriteLine($"{name} - fuel left {energy:f2}");
            }
        }
    }
}

