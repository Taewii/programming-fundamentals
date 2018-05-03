using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
       
        int count = 1;
        int tempCount = 0;
        int tempNumber = 0;       

        for (int i = 0; i < numbers.Count - 1; i++)
        {            
            if (numbers[i] == numbers[i + 1])
            {
                count++;
            }
            else
            {
                if (count > tempCount)
                {
                    tempCount = count;
                    tempNumber = numbers[i];
                    count = 1;
                    continue;
                }
                else
                {                   
                    count = 1;
                    continue;
                }
            }
        }

        string result = "";
        for (int i = 0; i < tempCount; i++)
        {
             result += tempNumber + " ";
        }
        Console.WriteLine(result);
    }
}

