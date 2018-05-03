using System;


class Program
{
    static void Main(string[] args)
    {
        double bpm = double.Parse(Console.ReadLine());
        double beats = double.Parse(Console.ReadLine());

        Console.Write($"{Math.Round(beats / 4, 1)} bars - ");

        double seconds = beats * 60.0 / bpm;
        int minutes = (int)seconds / 60;
        seconds -= minutes * 60;
        Console.Write($"{minutes}m {Math.Floor(seconds)}s");
    }
}

