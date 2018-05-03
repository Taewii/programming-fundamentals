using System;


class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();

        switch (type)
        {
            case "triangle":
                double side = double.Parse(Console.ReadLine());
                double heightTriangle = double.Parse(Console.ReadLine());
                TriangleArea(side, heightTriangle);
                break;
            case "square":
                double sideSquare = double.Parse(Console.ReadLine());
                SquareArea(sideSquare);
                break;
            case "rectangle":
                double width = double.Parse(Console.ReadLine());
                double heightRectangle = double.Parse(Console.ReadLine());
                RectangleArea(width, heightRectangle);
                break;
            case "circle":
                double radius = double.Parse(Console.ReadLine());
                CircleArea(radius);
                break;
        }
    }

    static void CircleArea(double radius)
    {
        Console.WriteLine($"{Math.PI * Math.Pow(radius, 2):f2}");
    }

    static void RectangleArea(double width, double heightRectangle)
    {
        Console.WriteLine($"{width * heightRectangle:f2}");
    }

    static void SquareArea(double sideSquare)
    {
        Console.WriteLine($"{sideSquare * sideSquare:f2}");
    }

    static void TriangleArea(double side, double height)
    {
        Console.WriteLine($"{(side * height) / 2:f2}");
    }
}

