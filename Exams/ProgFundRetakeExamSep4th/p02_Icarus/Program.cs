using System;
using System.Linq;

class p02_Icarus
{
    static void Main()
    {
        int[] plane = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int index = int.Parse(Console.ReadLine());
        int dmg = 1;

        string input;
        while ((input = Console.ReadLine()) != "Supernova")
        {
            string[] tokens = input.Split();
            string direction = tokens[0];
            int steps = int.Parse(tokens[1]);

            if (direction == "left")
            {
                for (int i = 0; i < steps; i++)
                {
                    if (index <= 0)
                    {
                        index = plane.Length;
                        dmg++;
                    }

                    plane[--index] -= dmg;
                }
            }
            else
            {
                for (int i = 0; i < steps; i++)
                {
                    if (index + 1 >= plane.Length)
                    {
                        index = -1;
                        dmg++;
                    }

                    plane[++index] -= dmg;
                }
            }
        }
        Console.WriteLine(string.Join(" ", plane));
    }
}
