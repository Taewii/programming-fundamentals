using System;
using System.Collections.Generic;
using System.Linq;

class p02_Entertain
{
    static void Main()
    {
        int power = int.Parse(Console.ReadLine());
        List<int> train = new List<int>();

        string input;
        while ((input = Console.ReadLine()) != "All ofboard!")
        {
            int wagon = int.Parse(input);
            int closest = int.MaxValue;
            int index = 0;

            train.Add(wagon);

            if (train.Sum() > power)
            {
                int average = train.Sum() / train.Count;

                for (int i = 0; i < train.Count; i++)
                {
                    if (train[i] > average)
                    {
                        int current = train[i] - average;

                        if (current < closest)
                        {
                            closest = current;
                            index = i;
                        }
                    }
                    else
                    {
                        int current = average - train[i];

                        if (current < closest)
                        {
                            closest = current;
                            index = i;
                        }
                    }
                }
                train.RemoveAt(index);
            }
        }

        train.Reverse();
        train.Add(power);

        Console.WriteLine(string.Join(" ", train));
    }
}