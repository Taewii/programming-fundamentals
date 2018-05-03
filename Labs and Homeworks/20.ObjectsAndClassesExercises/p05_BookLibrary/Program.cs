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

        Dictionary<string, double> SumByAuthor = new Dictionary<string, double>();

        foreach (var author in books)
        {
            if (!SumByAuthor.ContainsKey(author.Author))
            {
                SumByAuthor.Add(author.Author, author.Price);
            }
            else
            {
                SumByAuthor[author.Author] += author.Price;
            }         
        }

        foreach (var item in SumByAuthor.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} -> {item.Value:f2}");
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

