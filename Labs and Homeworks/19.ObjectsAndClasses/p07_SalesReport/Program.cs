using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Sale> allSales = new List<Sale>();

        while (n-- > 0)
        {
            string input = Console.ReadLine();
            string[] commandArgs = input.Split();

            Sale sales = new Sale();
            sales.Town = commandArgs[0];
            sales.Product = commandArgs[1];
            sales.Price = double.Parse(commandArgs[2]);
            sales.Quantity = double.Parse(commandArgs[3]);

            allSales.Add(sales);
        }

        SortedDictionary<string, double> sum = new SortedDictionary<string, double>();

        foreach (var item in allSales)
        {
            if (!sum.ContainsKey(item.Town))
            {
                sum.Add(item.Town, item.Quantity * item.Price);
            }
            else
            {
                sum[item.Town] += item.Quantity * item.Price;
            }
        }

        foreach (var town in sum)
        {
            Console.WriteLine($"{town.Key} -> {town.Value:f2}");
        }
    }
}

class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public double Price { get; set; }
    public double Quantity { get; set; }
}

