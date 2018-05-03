using System;

class p01_Wormtest
{
    static void Main()  // it can be waaaaaaaaay simpler, but cba chaning it lmao
    {
        long length = long.Parse(Console.ReadLine());
        double width = width = double.Parse(Console.ReadLine());

        if (width != 0)
        {
            double division = (length * 100) % width;
            double result = (length * 100) * width;

            if (division == 0)
            {
                Console.WriteLine($"{result:F2}");
            }
            else
            {
                Console.WriteLine($"{Math.Round(((length * 100) / width) * 100, 2)}%");
            }
        }
        else
        {
            double result = (length * 100) * width;
            Console.WriteLine($"{result:F2}");
        }     
    }
}