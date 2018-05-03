using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            array[i] = number;
        }

        for (int i = array.Length; i > 0; i--)
        {
            Console.WriteLine(array[i - 1]);
        }
    }
}

