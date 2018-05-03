using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] priceOfGoldAndJewels = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string loot = "";
        int expensesSum = 0;
        int earnings = 0;
        
        while (loot != "Jail Time")
        {
            loot = Console.ReadLine();
            string[] expenses = loot.Split().ToArray();
            if (loot != "Jail Time")
            {
            expensesSum += int.Parse(expenses[1]);
            }

            foreach (char c in loot)
            {
                if (c == '%')
                {
                    earnings += priceOfGoldAndJewels[0];
                }
                else if (c == '$')
                {
                    earnings += priceOfGoldAndJewels[1];
                }
            }
        }

        int finalResult = earnings - expensesSum;
        if (finalResult >= 0)
        {
            Console.WriteLine($"Heists will continue. Total earnings: {finalResult}.");
        }
        else
        {
            Console.WriteLine($"Have to find another job. Lost: {Math.Abs(finalResult)}.");
        }
    }
}

