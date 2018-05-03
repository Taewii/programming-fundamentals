using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Book> books = new List<Book>();

        while (n-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            Book book = new Book();
            book.Title = input[0];
            book.Author = input[1];
            book.Publisher = input[2];
            book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.ISBN = decimal.Parse(input[4]);
            book.Price = double.Parse(input[5]);

            books.Add(book);
        }

        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InstalledUICulture);

        Dictionary<string, DateTime> nameAndDate = new Dictionary<string, DateTime>();

        foreach (var author in books)
        {
            if (author.ReleaseDate > date)
            {
                nameAndDate.Add(author.Title, author.ReleaseDate);
            }
        }

        foreach (var item in nameAndDate.OrderBy(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} -> {item.Value:dd.MM.yyyy}");
        }
    }
}

class Book
{
    public string Title { get; set; }

    public string Author { get; set; }

    public string Publisher { get; set; }

    public DateTime ReleaseDate { get; set; }

    public decimal ISBN { get; set; }

    public double Price { get; set; }
}

