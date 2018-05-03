using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] ingredients = Console.ReadLine().Split().ToArray();
        int stringLength = int.Parse(Console.ReadLine());

        List<string> ingredientsAdded = new List<string>();
        int counter = 0;

        for (int i = 0; i < ingredients.Length; i++)
        {
            if (ingredients[i].Length == stringLength)
            {
                if (counter >= 10)
                {
                    break;
                }
                counter++;
                ingredientsAdded.Add(ingredients[i]);
                Console.WriteLine($"Adding {ingredients[i]}.");

            }
        }
        Console.WriteLine($"Made pizza with total of {counter} ingredients.");
        Console.WriteLine($"The ingredients are: {string.Join(", ", ingredientsAdded)}.");
    }
}

