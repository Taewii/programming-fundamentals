using System;
using System.Collections.Generic;
using System.Linq;

class p03_HornetAssault
{
    static void Main()
    {
        List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
        List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

        for (int i = 0; i < beehives.Count; i++)
        {
            long hornetPower = hornets.Sum();

            if (beehives[i] - hornetPower <= 0)
            {
                if (beehives[i] - hornetPower == 0 && hornets.Count != 0)
                {
                    hornets.RemoveAt(0);
                }
                beehives[i] = -1;
            }
            else
            {
                if (hornets.Count != 0)
                {
                    beehives[i] -= hornetPower;
                    hornets.RemoveAt(0);
                }
            }
        }

        beehives = beehives.Where(x => x != -1).ToList();

        if (beehives.Count != 0)
        {
            Console.WriteLine(string.Join(" ", beehives));
        }
        else
        {
            Console.WriteLine(string.Join(" ", hornets));
        }
    }
}

