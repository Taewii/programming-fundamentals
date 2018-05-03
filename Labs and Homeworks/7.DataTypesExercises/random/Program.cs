using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string previous = "";

        for (int i = 0; i < n; i++)
        {
            string current = Console.ReadLine();

            if (current == ")" && previous == "")
            {
                Console.WriteLine("UNBALANCED");
                return;
            }
            else if (current == "(" && previous == "(")
            {
                Console.WriteLine("UNBALANCED");
                return;
            }
            else if (current == ")" && previous == ")")
            {
                Console.WriteLine("UNBALANCED");
                return;
            }
            else if (current == "(")
            {
                previous = current;
            }
            else if (current == ")")
            {
                previous = current;
            }
        }
        if (previous == "(")
        {
            Console.WriteLine("UNBALANCED");
        }
        else
        {
            Console.WriteLine("BALANCED");
        }
    }
}