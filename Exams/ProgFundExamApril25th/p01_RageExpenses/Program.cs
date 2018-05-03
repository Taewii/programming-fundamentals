using System;

class p01_RageExpenses
{
    static void Main()
    {
        int lostGames = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        int brokenHeadsets = lostGames / 2;
        int brokenMice = lostGames / 3;
        int brokenKeyboards = lostGames / 6;
        int brokenDisplays = brokenKeyboards / 2;

        Console.WriteLine($"Rage expenses: {(brokenHeadsets * headsetPrice) + (brokenMice * mousePrice) + (brokenKeyboards * keyboardPrice) + (brokenDisplays * displayPrice):F2} lv.");
    }
}