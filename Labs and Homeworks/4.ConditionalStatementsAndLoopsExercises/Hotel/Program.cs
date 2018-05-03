using System;


class Program
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        double studio = 0;
        double doubleRoom = 0;
        double suite = 0;

        switch (month)
        {
            case "May":
            case "October":
                if (month == "October" && nights > 7)
                {
                    studio = ((nights - 1) * 50) * 0.95;
                }
                else if (nights > 7)
                {
                    studio = (nights * 50) * 0.95;
                }
                else
                {
                    studio = nights * 50;
                }
                doubleRoom = nights * 65;
                suite = nights * 75;
                break;
            case "June":
            case "September":
                if (month == "September" && nights > 7)
                {
                    studio = (nights - 1) * 60;
                }
                else
                {
                    studio = nights * 60;
                }
                if (nights > 14)
                {
                    doubleRoom = (nights * 72) * 0.9;
                }
                else
                {
                    doubleRoom = nights * 72;
                }
                suite = nights * 82;
                break;
            case "July":
            case "August":
            case "December":
                if (nights > 14)
                {
                    suite = (nights * 89) * 0.85;
                }
                else
                {
                    suite = nights * 89;
                }
                studio = nights * 68;
                doubleRoom = nights * 77;
                break;
        }
        Console.WriteLine($"Studio: {studio:f2} lv.");
        Console.WriteLine($"Double: {doubleRoom:f2} lv.");
        Console.WriteLine($"Suite: {suite:f2} lv.");
    }
}

