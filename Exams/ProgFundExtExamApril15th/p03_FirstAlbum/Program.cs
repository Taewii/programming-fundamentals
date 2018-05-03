using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class p03_FirstAlbum
{
    static void Main()
    {
        string lyricsPattern = @"""([A-Za-z ]+)""";
        string namePattern = @"\[([^- ][A-Za-z -]+[^- ])\]";
        string timePattern = @"(\d+:\d+)m|(\d+)s";
        List<string> songs = new List<string>();

        string input;
        while ((input = Console.ReadLine()) != "Rock on!")
        {
            if (!(Regex.IsMatch(input, lyricsPattern) && Regex.IsMatch(input, namePattern) && Regex.IsMatch(input, timePattern)))
            {
                continue;
            }

            string name = Regex.Match(input, namePattern).Groups[1].Value;
            string lyrics = Regex.Match(input, lyricsPattern).Groups[1].Value;
            var timeMatch = Regex.Match(input, timePattern);
            string time = timeMatch.Value.Substring(0, timeMatch.Length - 1);

            if (!time.Contains(":"))
            {
                TimeSpan t = TimeSpan.FromSeconds(double.Parse(time));
                time = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
            }

            string result = $"{name} -> {time} => {lyrics}";
            songs.Add(result);

            if (songs.Count == 4)
            {
                break;
            }
        }

        foreach (var song in songs)
        {
            Console.WriteLine(song);
        }
    }
}

