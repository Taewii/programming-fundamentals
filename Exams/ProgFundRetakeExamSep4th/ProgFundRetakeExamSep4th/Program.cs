using System;

class p01_Ressurection
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            long totalLength = long.Parse(Console.ReadLine());
            decimal totalWidth = decimal.Parse(Console.ReadLine());
            long lengthOfOneWing = long.Parse(Console.ReadLine());

            decimal totalYears = (decimal)(Math.Pow(totalLength, 2)) * (totalWidth + 2 * lengthOfOneWing);
            Console.WriteLine(totalYears);
        }
    }
}