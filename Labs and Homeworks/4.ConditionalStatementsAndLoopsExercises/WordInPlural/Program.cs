using System;


class Program
{
    static void Main(string[] args) //works fine here, but throws compile issues in judge?!?!?
    {
        string word = Console.ReadLine(); 

        if (word.EndsWith('y'))
        {
            word = word.Remove(word.Length - 1);
            Console.WriteLine(word + "ies");
        }
        else if (word.EndsWith('o') || word.EndsWith('s') || word.EndsWith('x') || word.EndsWith('z')
            || word.EndsWith("ch") || word.EndsWith("sh"))
        {
            Console.WriteLine(word + "es");
        }
        else
        {
            Console.WriteLine(word + "s");
        }
    }
}

