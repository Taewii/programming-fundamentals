using System;

class p01_BandMembers
{
    static void Main()
    {
        int memberCount = int.Parse(Console.ReadLine());
        double guitarPrice = double.Parse(Console.ReadLine());

        int guitarists = (int)Math.Floor(memberCount / 3d);
        int drummers = memberCount - 1 - guitarists;
        double drumsPrice = guitarPrice * 1.5;
        double microphonePrice = (drummers * drumsPrice) - (guitarists * guitarPrice);
        double rentPerMonth = (drumsPrice * drummers + guitarPrice * guitarists + microphonePrice) / memberCount;
        double rentForAYear = rentPerMonth * 12;
        double totalExpenses = rentForAYear + (drumsPrice * drummers + guitarPrice * guitarists + microphonePrice);

        Console.WriteLine($"Total cost: {totalExpenses:f2}lv.");
    }
}