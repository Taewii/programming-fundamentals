using System;


class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());

        string game = Console.ReadLine();  //taq zadacha otne bahti vremeto bateeeeeeee, but I did it thooooo
        double money = budget;

        double game1 = 39.99;
        double game2 = 15.99;
        double game3 = 19.99;
        double game4 = 59.99;
        double game5 = 29.99;
        double game6 = 39.99;

        while (money > 0)
        {
            switch (game)
            {
                case "OutFall 4":
                    if (money < game1)
                    {
                        Console.WriteLine("Too Expensive");
                        break;
                    }
                    else
                    {
                        money -= game1;
                        Console.WriteLine("Bought OutFall 4");
                        break;
                    }
                case "CS: OG":
                    if (money < game2)
                    {
                        Console.WriteLine("Too Expensive");
                        break;
                    }
                    else
                    {
                        money -= game2;
                        Console.WriteLine("Bought CS: OG");
                        break;
                    }
                case "Zplinter Zell":
                    if (money < game3)
                    {
                        Console.WriteLine("Too Expensive");
                        break;
                    }
                    else
                    {
                        money -= game3;
                        Console.WriteLine("Bought Zplinter Zell");
                        break;
                    }
                case "Honored 2":
                    if (money < game4)
                    {
                        Console.WriteLine("Too Expensive");
                        break;
                    }
                    else
                    {
                        money -= game4;
                        Console.WriteLine("Bought Honored 2");
                        break;
                    }
                case "RoverWatch":
                    if (money < game5)
                    {
                        Console.WriteLine("Too Expensive");
                        break;
                    }
                    else
                    {
                        money -= game5;
                        Console.WriteLine("Bought RoverWatch");
                        break;
                    }
                case "RoverWatch Origins Edition":
                    if (money < game6)
                    {
                        Console.WriteLine("Too Expensive");
                        break;
                    }
                    else
                    {
                        money -= game6;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        break;
                    }
                default:
                    if (game == "Game Time")
                    {
                        Console.WriteLine($"Total spent: ${budget - money:f2}. Remaining: ${money:f2}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Not Found");
                        break;
                    }
            }
            if (money == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            else
            {
                game = Console.ReadLine();
            }
        }
    }
}

