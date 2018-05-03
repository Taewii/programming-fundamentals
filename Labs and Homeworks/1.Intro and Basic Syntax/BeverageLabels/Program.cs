using System;


class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        double volume = double.Parse(Console.ReadLine());
        double energyContent = double.Parse(Console.ReadLine());
        double sugarContent = double.Parse(Console.ReadLine());

        double kcal = (volume * energyContent) / 100;
        double sugars = (sugarContent * volume) / 100;

        Console.WriteLine($"{volume}ml {name}:\n{kcal}kcal, {sugars}g sugars");
    }
}

