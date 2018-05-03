using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class p02_SpyGram
{
    static void Main()
    {
        int[] keys = Console.ReadLine().ToCharArray().Select(x => int.Parse("" + x)).ToArray();
        List<Messages> messages = new List<Messages>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            if (!Regex.IsMatch(input, @"^TO: [A-Z]+; MESSAGE: [ -~]+;$"))
            {
                continue;
            }

            string[] tokens = input.Split(';');
            string name = tokens[0].Substring(4);

            StringBuilder sb = new StringBuilder();

            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (counter == keys.Length)
                {
                    counter = 0;
                }

                sb.Append((char)(input[i] + keys[counter]));
                counter++;
            }

            Messages currentMessage = new Messages();
            currentMessage.Name = name;
            currentMessage.Message = sb.ToString();
            messages.Add(currentMessage);
        }

        foreach (var item in messages.OrderBy(x => x.Name))
        {
            Console.WriteLine(item.Message);
        }
    }
}

class Messages
{
    public string Name { get; set; }

    public string Message { get; set; }
}