using System;

class p01_HornetWings
{
    static void Main()
    {
        int wingFlaps = int.Parse(Console.ReadLine());
        double distanceForAThousandFlaps = double.Parse(Console.ReadLine());
        int endurance = int.Parse(Console.ReadLine());

        decimal distance = (decimal)((wingFlaps / 1000) * distanceForAThousandFlaps);
        decimal seconds = ((wingFlaps / endurance) * 5) + (wingFlaps / 100);

        Console.WriteLine($"{distance:f2} m.");
        Console.WriteLine($"{seconds} s.");
    }
}

