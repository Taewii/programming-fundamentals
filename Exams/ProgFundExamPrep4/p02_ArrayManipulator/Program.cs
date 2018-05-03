using System;
using System.Collections.Generic;
using System.Linq;

class p02_ArrayManipulator
{
    static void Main()
    {
        List<int> startArray = Console.ReadLine().Split().Select(int.Parse).ToList();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] tokens = input.Split();
            string command = tokens[0];

            switch (command)
            {
                case "exchange":
                    int index = int.Parse(tokens[1]);
                    if (index < 0 || index >= startArray.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        startArray = ExchangeArray(startArray, index);
                    }
                    break;
                case "max":
                    string oddOrEven = tokens[1];
                    if (oddOrEven == "even")
                    {
                        IndexOfMaxEvenElement(startArray);
                    }
                    else
                    {
                        IndexOfMaxOddElement(startArray);
                    }
                    break;
                case "min":
                    oddOrEven = tokens[1];
                    if (oddOrEven == "even")
                    {
                        IndexOfMinEvenElement(startArray);
                    }
                    else
                    {
                        IndexOfMinOddElement(startArray);
                    }
                    break;
                case "first":
                    int count = int.Parse(tokens[1]);
                    oddOrEven = tokens[2];

                    if (count > startArray.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (oddOrEven == "even")
                        {
                            FirstIndexEvenElements(count, startArray);
                        }
                        else
                        {
                            FirstIndexOddElements(count, startArray);
                        }
                    }
                    break;
                case "last":
                    count = int.Parse(tokens[1]);
                    oddOrEven = tokens[2];

                    if (count > startArray.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (oddOrEven == "even")
                        {
                            LastIndexEvenElements(count, startArray);
                        }
                        else
                        {
                            FirstIndexOddElements(count, startArray);
                        }
                    }
                    break;
            }
        }

        Console.WriteLine($"[{string.Join(", ", startArray)}]");
    }

    static void LastIndexEvenElements(int count, List<int> startArray)
    {
        List<int> result = new List<int>();

        for (int i = startArray.Count - 1; i >= 0; i--)
        {
            if (startArray[i] % 2 == 0)
            {
                result.Add(startArray[i]);
            }

            if (result.Count == count)
            {
                break;
            }
        }

        result.Reverse();
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }

    static void LastIndexOddElements(int count, List<int> startArray)
    {
        List<int> result = new List<int>();

        for (int i = startArray.Count - 1; i >= 0; i--)
        {
            if (startArray[i] % 2 == 1)
            {
                result.Add(startArray[i]);
            }

            if (result.Count == count)
            {
                break;
            }
        }

        result.Reverse();
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }

    static void FirstIndexOddElements(int count, List<int> startArray)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < startArray.Count; i++)
        {
            if (startArray[i] % 2 == 1)
            {
                result.Add(startArray[i]);
                if (result.Count == count)
                {
                    break;
                }
            }
        }
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }

    static void FirstIndexEvenElements(int count, List<int> startArray)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < startArray.Count; i++)
        {
            if (startArray[i] % 2 == 0)
            {
                result.Add(startArray[i]);
                if (result.Count == count)
                {
                    break;
                }
            }
        }
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }

    static void IndexOfMinOddElement(List<int> startArray)
    {
        int result = int.MaxValue;
        int index = 0;

        for (int i = 0; i < startArray.Count; i++)
        {
            if (startArray[i] % 2 == 1 && startArray[i] <= result)
            {
                result = startArray[i];
                index = i;
            }
        }

        if (result == int.MaxValue)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(index);
        }
    }

    static void IndexOfMinEvenElement(List<int> startArray)
    {
        int result = int.MaxValue;
        int index = 0;

        for (int i = 0; i < startArray.Count; i++)
        {
            if (startArray[i] % 2 == 0 && startArray[i] <= result)
            {
                result = startArray[i];
                index = i;
            }
        }

        if (result == int.MaxValue)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(index);
        }
    }

    static void IndexOfMaxEvenElement(List<int> startArray)
    {
        int result = int.MinValue;
        int index = 0;

        for (int i = 0; i < startArray.Count; i++)
        {
            if (startArray[i] % 2 == 0 && startArray[i] >= result)
            {
                result = startArray[i];
                index = i;
            }
        }

        if (result == int.MinValue)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(index);
        }
    }

    static void IndexOfMaxOddElement(List<int> startArray)
    {
        int result = int.MinValue;
        int index = 0;

        for (int i = 0; i < startArray.Count; i++)
        {
            if (startArray[i] % 2 == 1 && startArray[i] >= result)
            {
                result = startArray[i];
                index = i;
            }
        }

        if (result == int.MinValue)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(index);
        }
    }

    static List<int> ExchangeArray(List<int> startArray, int index)
    {

        List<int> first = startArray.Skip(index + 1).ToList();
        List<int> second = startArray.Take(index + 1).ToList();
        List<int> result = first.Concat(second).ToList();

        return result;
    }
}