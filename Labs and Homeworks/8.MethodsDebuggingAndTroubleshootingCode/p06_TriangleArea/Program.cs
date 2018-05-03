using System;


class Program
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double heigth = double.Parse(Console.ReadLine());
        double result = TriangleArea(width, heigth);
        Console.WriteLine(result);
    }

    static double TriangleArea(double width, double heigth)
    {
        return width * heigth / 2;
    }
}

