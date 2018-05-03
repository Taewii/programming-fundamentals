using System;


class Program
{
    static void Main(string[] args)
    {
        string convertToBoolean = Console.ReadLine();

        Convert.ToBoolean(convertToBoolean);

        if (convertToBoolean == "True")
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
      
    }
}

