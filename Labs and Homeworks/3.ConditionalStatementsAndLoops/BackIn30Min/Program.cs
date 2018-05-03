using System;


class Program
{
    static void Main(string[] args)
    {
        var hr = int.Parse(Console.ReadLine());
        var min = int.Parse(Console.ReadLine());

        var minutes = min + 30;
        var hours = hr;

        if (minutes > 59)
        {
            hours++;
            minutes -= 60;
        }
        if (hours >= 24)
        {
            hours -= 24;
        }
        Console.WriteLine($"{hours}:{minutes:d2}");

    }
}

