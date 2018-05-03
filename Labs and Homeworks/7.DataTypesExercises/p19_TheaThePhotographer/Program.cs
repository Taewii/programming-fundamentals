using System;


class Program
{
    static void Main(string[] args)
    {
        long totalPictures = long.Parse(Console.ReadLine());
        long filterTime = long.Parse(Console.ReadLine());
        long filterFactor = long.Parse(Console.ReadLine());
        long uploadTime = long.Parse(Console.ReadLine());

        long usefulPictures = (long) Math.Ceiling(totalPictures * filterFactor / 100.0);
        long timeForAllPics = totalPictures * filterTime;
        long filteredPictures = usefulPictures * uploadTime;
        long totalTime = timeForAllPics + filteredPictures;

        TimeSpan result = TimeSpan.FromSeconds(totalTime);
        string end = result.ToString(@"d\:hh\:mm\:ss");
        Console.WriteLine(end);
    }
}

 