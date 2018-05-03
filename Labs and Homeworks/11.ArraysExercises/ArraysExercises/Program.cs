using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] first = Console.ReadLine().Split(' ').ToArray();
        string[] second = Console.ReadLine().Split(' ').ToArray();

        int result = CommonWordsInStrings(first, second);
        Array.Reverse(first);
        Array.Reverse(second);
        int result2 = CommonWordsInStrings(first, second);

        Console.WriteLine(Math.Max(result, result2));
    }

    static int CommonWordsInStrings (string[] first, string[] second)
    {
        int length = Math.Min(first.Length, second.Length);
        int counter = 0;

        for (int i = 0; i < length; i++)
        {
            if (first[i] == second[i])
            {
                counter++;
            }
            else
            {
                break;
            }
        }
        return counter;
    }
}

