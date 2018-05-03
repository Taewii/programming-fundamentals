using System;

namespace Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", width * height);
        }
    }
}
