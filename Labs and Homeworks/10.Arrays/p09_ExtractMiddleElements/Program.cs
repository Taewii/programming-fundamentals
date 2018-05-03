using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        if (numbers.Length == 1)
        {
            Console.WriteLine("{ " + string.Join(", ", numbers) + " }");
        }
        else if (numbers.Length % 2 == 0)
        {
            int[] middle = new int[2];
            middle[0] = numbers[numbers.Length / 2 - 1];
            middle[1] = numbers[numbers.Length / 2];
            
            Console.WriteLine("{ " + string.Join(", ", middle) + " }");
        }
        else if (numbers.Length % 2 == 1)
        {
            int[] middle = new int[3];
            middle[0] = numbers[numbers.Length / 2 - 1];
            middle[1] = numbers[numbers.Length / 2];
            middle[2] = numbers[numbers.Length / 2 + 1];

            Console.WriteLine("{ " + string.Join(", ", middle) + " }");
        }
    }
}

