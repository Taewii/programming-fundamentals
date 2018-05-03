using System;
using System.Numerics;

class p01_Trainers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger technical = 0;
        BigInteger practical = 0;
        BigInteger theoretical = 0;

        for (int i = 0; i < n; i++)
        {
            long distanceToTravel = long.Parse(Console.ReadLine());
            double cargo = double.Parse(Console.ReadLine());
            string teamName = Console.ReadLine();

            decimal earnedMoney = (decimal)(((cargo * 1000) * 1.5) - (0.7 * (distanceToTravel * 1600) * 2.5));

            if (teamName == "Technical")
            {
                technical += (BigInteger)earnedMoney;
            }
            else if (teamName == "Practical")
            {
                practical += (BigInteger)earnedMoney;
            }
            else
            {
                theoretical += (BigInteger)earnedMoney;
            }
        }

        BigInteger result = BigInteger.Max(technical, practical);
        BigInteger final = BigInteger.Max(result, theoretical);

        if (final == theoretical)
        {
            Console.WriteLine($"The Theoretical Trainers win with ${final:f3}.");
        }
        else if (final == practical)
        {
            Console.WriteLine($"The Practical Trainers win with ${final:f3}.");
        }
        else
        {
            Console.WriteLine($"The Technical Trainers win with ${final:f3}.");
        }
    }
}