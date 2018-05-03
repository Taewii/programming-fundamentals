using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int cheese = 0;
        int tomatoSauce = 0;
        int salami = 0;
        int pepper = 0;

        for (int i = 0; i < n; i++)
        {
            string ingredient = Console.ReadLine().ToLower();

            switch (ingredient)
            {
                case "cheese":
                    cheese++;
                    break;
                case "tomato sauce":
                    tomatoSauce++;
                    break;
                case "salami":
                    salami++;
                    break;
                case "pepper":
                    pepper++;
                    break;
            }
        }
        Console.WriteLine("Total calories: {0}", cheese * 500 + tomatoSauce * 150 + salami * 600 +  pepper * 50);
    }
}

