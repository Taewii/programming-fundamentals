using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class p03_Trainegram
{
    static void Main()
    {
        string pattern = @"^\<\[[^A-Za-z0-9]*\]\.(\.\[[A-Za-z0-9]*\]\.)*$";
        List<string> trains = new List<string>();

        string input;
        while ((input = Console.ReadLine()) != "Traincode!")
        {
            if (Regex.IsMatch(input, pattern))
            {
                trains.Add(input);
            }
        }

        foreach (var train in trains)
        {
            Console.WriteLine(train);
        }
    }
}