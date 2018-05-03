using System;


class Program
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        string type = Console.ReadLine();

        switch (type)
        {
            case "face":
                GetFace(n);
                break;
           case "space":
               GetSpace(n);
               break;
           case "volume":
               GetVolume(n);
               break;
           case "area":
               GetArea(n);
                break;
        }
    }

    static void GetArea(double number)
    {
        Console.WriteLine($"{6 * Math.Pow(number, 2):f2}");
    }

    static void GetVolume(double number)
    {
        Console.WriteLine($"{Math.Pow(number, 3):f2}");
    }

    static void GetSpace(double number)
    {
        Console.WriteLine($"{Math.Sqrt(3 * (Math.Pow(number, 2))):f2}");
    }

    static void GetFace(double number)
    {
        Console.WriteLine($"{Math.Sqrt(2 * (Math.Pow(number, 2))):f2}");
    }
}

