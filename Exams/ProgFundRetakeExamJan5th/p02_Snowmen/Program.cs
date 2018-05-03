using System;
using System.Collections.Generic;
using System.Linq;

class p02_Snowmen
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> lostOrDead = new List<int>();

        while (numbers.Count > 1)
        {
            int attacker = 0;
            foreach (var num in numbers)
            {
                if (num > numbers.Count)
                {
                    attacker = num % numbers.Count;
                    attacker = numbers.IndexOf(attacker);
                }
                else
                {
                    attacker = numbers.IndexOf(num);
                }
                int target = num;

                int result = Math.Abs(attacker - num);

                if (attacker == target)
                {
                    Console.WriteLine($"{attacker} performed harakiri");
                    numbers.Remove(attacker);
                }
                else if (result % 2 == 0)
                {
                    Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                    numbers.Remove(attacker);
                }
                else if (result % 2 == 1)
                {
                    Console.WriteLine($"{attacker} x {target} -> {target} wins");
                    numbers.Remove(target);
                }                
            }
        }
    }
}

