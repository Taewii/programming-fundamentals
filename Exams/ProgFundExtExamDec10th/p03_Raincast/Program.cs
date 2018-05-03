using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class p03_Raincast
{
    static void Main() // no lie, I'm really fucking happy that I did this all by myself.
    {                  // the dumb thing is: I didn't need to store the fucking results so I could've just printed them... fml
        Dictionary<int, Raincasts> idk = new Dictionary<int, Raincasts>();

        string lookingFor = "Type";
        int counter = 1;

        string input;
        while ((input = Console.ReadLine()) != "Davai Emo")
        {
            string[] tokens = input.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length != 2)
            {
                continue;
            }

            string type = tokens[0];
            string message = tokens[1];

            if (!idk.ContainsKey(counter))
            {
                idk.Add(counter, new Raincasts());
            }

            if (lookingFor == type && type == "Type")
            {
                if (message == "Normal" || message == "Warning" || message == "Danger")
                {
                    idk[counter].Type = message;
                    lookingFor = "Source";
                }

            }
            else if (lookingFor == type && type == "Source")
            {
                if (Regex.IsMatch(message, "^[A-Za-z0-9]+$"))
                {
                    idk[counter].Source = message;
                    lookingFor = "Forecast";
                }

            }
            else if (lookingFor == type && type == "Forecast")
            {
                if (Regex.IsMatch(message, @"^[^!.,?]+$"))
                {
                    idk[counter].Forecast = message;
                    lookingFor = "Type";
                    counter++;
                }
            }
        }

        foreach (var cast in idk)
        {
            if (cast.Value.Type == null || cast.Value.Source == null || cast.Value.Forecast == null)
            {
                continue;
            }
            Console.WriteLine($"({cast.Value.Type}) {cast.Value.Forecast} ~ {cast.Value.Source}");
        }
    }
}

class Raincasts
{
    public string Type { get; set; }

    public string Source { get; set; }

    public string Forecast { get; set; }
}

