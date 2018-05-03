using System;


class Program
{
    static void Main(string[] args)
    {
        int counter = 0;

        for (int i = 0; i <= 100; i++)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                counter++;
            }
            catch (Exception)
            {
                break;
            }
        }
        Console.WriteLine(counter);
    }
}

