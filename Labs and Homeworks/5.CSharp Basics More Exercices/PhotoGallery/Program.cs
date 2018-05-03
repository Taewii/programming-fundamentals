using System;


class Program
{
    static void Main(string[] args)
    {
        int name = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        double size = double.Parse(Console.ReadLine());
        int resolution = int.Parse(Console.ReadLine());
        int orientation = int.Parse(Console.ReadLine());

        Console.WriteLine($"Name: DSC_{name:d4}.jpg");
        Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");

        if (size < 1024)
        {
            Console.WriteLine($"Size: {size}B");
        }
        else if (size < 1024 * 1000)
        {
            Console.WriteLine($"Size: {size / 1000}KB");
        }
        else
        {
            Console.WriteLine($"Size: {size / 1000000}MB");
        }

        if (resolution == orientation)
        {
            Console.WriteLine($"Resolution: {resolution}x{orientation} (square)");
        }
        else if (resolution > orientation)
        {
            Console.WriteLine($"Resolution: {resolution}x{orientation} (landscape)");
        }
        else
        {
            Console.WriteLine($"Resolution: {resolution}x{orientation} (portrait)");
        }
    }
}

