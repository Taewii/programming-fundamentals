using System;


class Program
{
    static void Main(string[] args)
    {
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());
        char magic = char.Parse(Console.ReadLine());

        for (char i = first; i <= second; i++)
        {
            for (char j = first; j <= second ; j++)
            {
                for (char l = first; l <= second; l++)
                {
                    if (l == magic || j == magic || i == magic)
                    {
                        
                    }
                    else
                    {
                        Console.Write($"{i}{j}{l} ");
                    }
                }
            }
        }
    }
}

