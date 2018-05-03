using System;


class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string result = "";

        int punchStr = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '>')
            {
                punchStr += int.Parse(input[i + 1].ToString());
            }
            else if (punchStr > 0)
            {
                punchStr--;
                continue;
            }
            result += input[i];
        }
        Console.WriteLine(result);
    }
}

