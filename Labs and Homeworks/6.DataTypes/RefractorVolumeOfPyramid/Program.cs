using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Length: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Pyramid Volume: {0:F2}", (width * length * height) / 3);
    }
}

