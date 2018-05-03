using System;


class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        Random rnd = new Random();

        for (int i = 0; i < input.Length - 1; i++)
        {
            int index = rnd.Next(0, input.Length);
            string rem = input[index];
            int newIndex = rnd.Next(0, input.Length);
            input[index] = input[newIndex];
            input[newIndex] = rem;
        }

        for (int j = 0; j < input.Length; j++)
        {
            Console.WriteLine(input[j]);
        }
    }
}
