using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class p02_MemoryView
{
    static void Main()
    {
        StringBuilder wholeInput = new StringBuilder();

        string input;
        while ((input = Console.ReadLine()) != "Visual Studio crash")
        {
            wholeInput.Append(input + " ");
        }

        string[] strings = wholeInput
            .ToString()
            .Split(new[] { "32656 19759 32763" }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var item in strings)
        {
            List<int> chars = item
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x != 0)
                .ToList();

            if (chars.Count == 0)
            {
                continue;
            }

            int index = chars[0];
            chars.RemoveAt(0);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < index; i++)
            {
                result.Append((char)chars[i]);
            }

            Console.WriteLine(result.ToString());
        }
    }
}