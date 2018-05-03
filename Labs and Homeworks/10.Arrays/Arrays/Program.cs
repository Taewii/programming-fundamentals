﻿using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] arr =
         {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday",
         };

        if (n <= 0 || n > 7)
        {
            Console.WriteLine("Invalid Day!");
        }
        else
        {
            Console.WriteLine(arr.GetValue(n - 1));
        }
    }
}

