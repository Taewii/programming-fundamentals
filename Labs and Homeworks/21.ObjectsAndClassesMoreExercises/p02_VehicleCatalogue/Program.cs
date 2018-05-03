using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        List<Vehicle> catalogue = new List<Vehicle>();

        while (input != "End")
        {
            string[] commandArgs = input.Split();
            string type = commandArgs[0].ToLower();
            string model = commandArgs[1];
            string color = commandArgs[2];
            int horsepower = int.Parse(commandArgs[3]);

            Vehicle vehicle = new Vehicle();
            vehicle.Type = type;
            vehicle.Model = model;
            vehicle.Color = color;
            vehicle.Horsepower = horsepower;

            catalogue.Add(vehicle);

            input = Console.ReadLine();
        }

        while (true)
        {
            input = Console.ReadLine();

            if (input == "Close the Catalogue")
            {
                break;
            }

            foreach (var car in catalogue)
            {
                if (car.Model.Contains(input))
                {
                    Console.WriteLine($"Type: {FirstLetterToUpper(car.Type)}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Color: {car.Color}");
                    Console.WriteLine($"Horsepower: {car.Horsepower}");
                }
            }
        }

        double trucks = 0;
        int truckCount = 0;
        double cars = 0;
        int carCount = 0;

        foreach (var car in catalogue)
        {
            if (car.Type == "truck")
            {
                trucks += car.Horsepower;
                truckCount++;
            }
            else
            {
                cars += car.Horsepower;
                carCount++;
            }
        }

        if (cars == 0)
        {
            Console.WriteLine($"Cars have average horsepower of: 0.00.");
        }
        else
        {
            Console.WriteLine($"Cars have average horsepower of: {cars / carCount:f2}.");
        }

        if (trucks == 0)
        {
            Console.WriteLine($"Trucks have average horsepower of: 0.00.");
        }
        else
        {
            Console.WriteLine($"Trucks have average horsepower of: {trucks / truckCount:f2}.");
        }
    }

    public static string FirstLetterToUpper(string str)
    {
        if (str == null)
            return null;

        if (str.Length > 1)
            return char.ToUpper(str[0]) + str.Substring(1);

        return str.ToUpper();
    }
}

class Vehicle
{
    public string Type { get; set; }

    public string Model { get; set; }

    public string Color { get; set; }

    public int Horsepower { get; set; }
}

