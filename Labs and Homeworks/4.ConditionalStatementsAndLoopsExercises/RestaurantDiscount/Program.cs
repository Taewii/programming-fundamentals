using System;


class Program
{
    static void Main(string[] args)
    {
        int people = int.Parse(Console.ReadLine());
        string package = Console.ReadLine();

        switch (package)
        {
            case "Normal":
                if (people <= 50)
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((2500 + 500) * 0.95) / people);
                }
                else if (people <= 100)
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", ((5000 + 500) * 0.95) / people);
                }
                else if (people <= 120)
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((7500 + 500) * 0.95) / people);
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                }
                break;
            case "Gold":
                if (people <= 50)
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((2500 + 750) * 0.9) / people);
                }
                else if (people <= 100)
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", ((5000 + 750) * 0.9) / people);
                }
                else if (people <= 120)
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((7500 + 750) * 0.9) / people);
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                }
                break;
            case "Platinum":
                if (people <= 50)
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((2500 + 1000) * 0.85) / people);
                }
                else if (people <= 100)
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", ((5000 + 1000) * 0.85) / people);
                }
                else if (people <= 120)
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", ((7500 + 1000) * 0.85) / people);
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                }
                break;
        }
    }
}

