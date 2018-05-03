using System;


class Program
{
    static void Main(string[] args)
    {
        int people = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        double peoplePerRide = people / capacity;

        if (people % capacity != 0)
        {
            peoplePerRide++;
        }

        Console.WriteLine(peoplePerRide);
    }
}

