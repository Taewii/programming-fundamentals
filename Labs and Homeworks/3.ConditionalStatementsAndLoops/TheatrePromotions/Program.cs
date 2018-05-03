using System;


class Program
{
    static void Main(string[] args)
    {
        string typeOfDay = Console.ReadLine().ToLower();
        int age = int.Parse(Console.ReadLine());

        int value = 0;

        switch (typeOfDay)
        {
            case "weekday":
                if (age <= 18)
                {
                    value = 12;
                }
                else if (age <= 64)
                {
                    value = 18;
                }
                else if (age <= 122)
                {
                    value = 12;
                }
                break;
            case "weekend":
                if (age <= 18)
                {
                    value = 15;
                }
                else if (age <= 64)
                {
                    value = 20;
                }
                else if (age <= 122)
                {
                    value = 15;
                }
                break;
            case "holiday":
                if (age <= 18)
                {
                    value = 5;
                }
                else if (age <= 64)
                {
                    value = 12;
                }
                else if (age <= 122)
                {
                    value = 10;
                }
                break;
        }

        if (age > 122 || age < 0)
        {
            Console.WriteLine("Error!");
        }
        else
        {
            Console.WriteLine($"{value}$");
        }
    }
}

