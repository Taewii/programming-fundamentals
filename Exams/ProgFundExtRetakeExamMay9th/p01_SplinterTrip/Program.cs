using System;

class p01_SplinterTrip
{
    static void Main()
    {
        double tripDistance = double.Parse(Console.ReadLine());
        double fuelTankCapacity = double.Parse(Console.ReadLine());
        double milesSpentInHeavyWinds = double.Parse(Console.ReadLine());
      
        double nonHeavyWindsConsumption = (tripDistance - milesSpentInHeavyWinds) * 25;
        double heavyWindsConsumption = milesSpentInHeavyWinds * (25 * 1.5);
        double fuelConsumptions = nonHeavyWindsConsumption + heavyWindsConsumption;
        double tolerance = fuelConsumptions - (fuelConsumptions * 0.95);
        double totalFuel = fuelConsumptions + tolerance;

        Console.WriteLine($"Fuel needed: {totalFuel:f2}L");

        if (totalFuel <= fuelTankCapacity)
        {
            Console.WriteLine($"Enough with {fuelTankCapacity - totalFuel:f2}L to spare!");
        }
        else
        {
            Console.WriteLine($"We need {totalFuel - fuelTankCapacity:f2}L more fuel.");
        }
    }
}

