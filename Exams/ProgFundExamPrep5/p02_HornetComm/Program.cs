using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class p02_HornetComm
{
    static void Main()
    {
        string messagePattern = @"^[0-9]+ <-> [A-Za-z0-9]+$";
        string broadcastPattern = @"^[^0-9]+ <-> [A-Za-z0-9]+$";

        List<string> messages = new List<string>();
        List<string> broadcasts = new List<string>();

        string input;
        while ((input = Console.ReadLine()) != "Hornet is Green")
        {
            if (Regex.IsMatch(input, messagePattern))
            {
                string[] tokens = input.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                string recipient = Reverse(tokens[0]);
                string message = tokens[1];
                string result = recipient + " -> " + message;

                messages.Add(result);
            }
            else if (Regex.IsMatch(input, broadcastPattern))
            {
                string[] tokens = input.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                string frequency = CaseChanger(tokens[1]);
                string message = tokens[0];
                string result = frequency + " -> " + message;

                broadcasts.Add(result);
            }
        }

        Console.WriteLine("Broadcasts:");
        if (broadcasts.Count == 0)
        {
            Console.WriteLine("None");
        }
        foreach (var item in broadcasts)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Messages:");
        if (messages.Count == 0)
        {
            Console.WriteLine("None");
        }
        foreach (var item in messages)
        {
            Console.WriteLine(item);
        }
    }

    static string CaseChanger(string word)
    {
        string result = "";

        foreach (var ch in word)
        {
            if (char.IsLower(ch))
            {
                result += ch.ToString().ToUpper();
            }
            else if (char.IsUpper(ch))
            {
                result += ch.ToString().ToLower();
            }
            else
            {
                result += ch;
            }
        }
        return result;
    }

    static string Reverse(string word)
    {
        string result = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            result += word[i];
        }
        return result;
    }
}

