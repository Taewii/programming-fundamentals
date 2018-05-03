using System;
using System.Globalization;

class p01_SinoTheWalker
{
    static void Main()
    {
        string currentTime = Console.ReadLine();
        long numberSteps = long.Parse(Console.ReadLine());
        long timeForAStep = long.Parse(Console.ReadLine());

        DateTime time = DateTime.ParseExact(currentTime, "HH:mm:ss", CultureInfo.InvariantCulture);

        double day = 24 * 60 * 60;
        double totalSeconds = numberSteps * timeForAStep;
        totalSeconds = totalSeconds % day;

        DateTime result = time.AddSeconds(totalSeconds); 

        Console.WriteLine($"Time Arrival: {result.ToString("HH:mm:ss")}");
    }
}

