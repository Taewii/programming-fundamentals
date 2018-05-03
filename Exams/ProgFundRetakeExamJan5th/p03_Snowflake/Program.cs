using System;
using System.Text.RegularExpressions;

class p03_Snowflake
{
    static void Main()
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string input3 = Console.ReadLine();
        string input4 = Console.ReadLine();
        string input5 = Console.ReadLine();

        string surface = @"^[^A-Za-z0-9]+$";
        string mantle = @"^[0-9_]+$";
        string core = @"^[^A-Za-z0-9]+[0-9_]+(?<core>[A-Za-z]+)[0-9_]+[^A-Za-z0-9]+$";

        if (!(Regex.IsMatch(input1, surface) && Regex.IsMatch(input5, surface)))
        {
            Console.WriteLine("Invalid");
            return;
        }
        else if (!(Regex.IsMatch(input2, mantle) && Regex.IsMatch(input4, mantle)))
        {
            Console.WriteLine("Invalid");
            return;
        }
        else if (!Regex.IsMatch(input3, core))
        {
            Console.WriteLine("Invalid");
            return;
        }
        else
        {
            var coreMatch = Regex.Match(input3, core);
            int coreLength = coreMatch.Groups["core"].Length;

            Console.WriteLine("Valid");
            Console.WriteLine(coreLength);
        }       
    }
}

