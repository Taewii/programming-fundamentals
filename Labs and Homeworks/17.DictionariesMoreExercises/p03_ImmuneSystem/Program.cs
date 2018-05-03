using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static object list;

    static void Main(string[] args)
    {
        int immuneSystemHealth = int.Parse(Console.ReadLine());
        string virusName = Console.ReadLine();
        Dictionary<string, int> virusNames = new Dictionary<string, int>();

        int remaingingHealth = 0;
        int counter = 0;

        while (virusName != "end")
        {
            counter++;
            if (!virusNames.ContainsKey(virusName))
            {
                virusNames.Add(virusName, 1);
            }
            else
            {
                virusNames[virusName]++;
            }
            int virusHealth = GetVirusHealth(virusName);
            int virusHealthInSeconds = 0;
            if (!virusNames[virusName].Equals(1))
            {
                virusHealthInSeconds = (virusHealth * virusName.Length) / 3;
            }
            else
            {
                virusHealthInSeconds = virusHealth * virusName.Length;
            }
            Console.WriteLine($"Virus {virusName}: {virusHealth} => {virusHealthInSeconds} seconds");
            TimeSpan timeMin = TimeSpan.FromMinutes(virusHealthInSeconds);
            TimeSpan timeSec = TimeSpan.FromSeconds(virusHealthInSeconds);
            if (counter == 1)
            {

                remaingingHealth = immuneSystemHealth;
            }
            remaingingHealth -= virusHealthInSeconds;
            if (remaingingHealth <= 0)
            {
                Console.WriteLine($"Immune System Defeated.");
                return;
            }
            Console.WriteLine(string.Format("{0} defeated in {1}m {2}s.", virusName, (int)timeMin.TotalMinutes / 60, timeSec.Seconds));
            Console.WriteLine($"Remaining health: {remaingingHealth}");
            if (remaingingHealth * 1.2 > immuneSystemHealth)
            {
                remaingingHealth = immuneSystemHealth;
            }
            else
            {
                remaingingHealth = (int)(remaingingHealth * 1.2);
            }
            virusName = Console.ReadLine();
        }
        Console.WriteLine($"Final Health: {remaingingHealth}");
    }

    private static int GetVirusHealth(string virusName)
    {
        int result = 0;
        char[] chars = virusName.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            result += chars[i];
        }

        int result2 = (result / 3);

        return result2;
    }
}

