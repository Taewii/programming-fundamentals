using System;
using System.Collections.Generic;
using System.Linq;

class p02_Snowmen2
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        HashSet<int> lostOrDead = new HashSet<int>();

        while (numbers.Count > 1)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int attacker = i;
                int target = numbers[attacker] % numbers.Count;
                int result = Math.Abs(attacker - target);

                if (numbers.Count - lostOrDead.Count == 1)
                {
                    break;
                }

                if (lostOrDead.Contains(attacker))
                {
                    continue;
                }

                if (attacker == target)
                {
                    Console.WriteLine($"{attacker} performed harakiri");
                    lostOrDead.Add(attacker);
                    numbers[attacker] = -1;
                }
                else if (result % 2 == 0)
                {
                    Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                    lostOrDead.Add(target);
                    numbers[target] = -1;
                }
                else
                {
                    Console.WriteLine($"{attacker} x {target} -> {target} wins");
                    lostOrDead.Add(attacker);
                    numbers[attacker] = -1;
                }
            }
            numbers = numbers.Where(x => x != -1).ToList();
            lostOrDead.Clear();
        }
    }
}

