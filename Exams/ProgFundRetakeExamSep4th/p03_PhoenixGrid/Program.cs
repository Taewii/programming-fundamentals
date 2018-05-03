using System;
using System.Text.RegularExpressions;

class p03_PhoenixGrid
{
    static void Main()
    {
        string pattern = @"^([^\s_]{3}\.)*[^\s_]{3}$";

        string input;
        while ((input = Console.ReadLine()) != "ReadMe")
        {
            if (!Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("NO");
                continue;
            }

            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            if (input == reversed)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}