using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, decimal> shopList = new Dictionary<string, decimal>();
        string command = String.Empty;

        while (n-- > 0)
        {
            string[] input = Console.ReadLine().Split('-');
            string item = input[0];
            decimal price = decimal.Parse(input[1]);

            if (!shopList.ContainsKey(item))
            {
                shopList.Add(item, price);
            }
            else
            {
                shopList[item] = price;
            }
        }

        List<Client> clients = new List<Client>();

        while (true)
        {
            command = Console.ReadLine();
            if (command == "end of clients")
            {
                break;
            }

            string[] commandArgs = command.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string name = commandArgs[0];
            string product = commandArgs[1];
            int quantity = int.Parse(commandArgs[2]);

            if (shopList.ContainsKey(product))
            {
                Client client = new Client();
                bool customerIsPresent = false;

                client.Name = name;
                client.clientShopList = new Dictionary<string, int>();
                client.clientShopList.Add(product, quantity);
                client.Bill = client.Bill + shopList[product] * quantity;

                foreach (var c in clients)
                {
                    if (c.Name == client.Name)
                    {
                        customerIsPresent = true;
                        if (c.clientShopList.ContainsKey(product))
                        {
                            c.clientShopList[product] += quantity;
                        }
                        else
                        {
                            c.clientShopList.Add(product, quantity);
                        }
                        c.Bill += shopList[product] * quantity;
                    }
                }

                if (!customerIsPresent)
                {
                    clients.Add(client);
                }
            }
        }

        decimal totalBill = 0;
        foreach (var c in clients.OrderBy(c => c.Name))
        {
            Console.WriteLine(c.Name);
            foreach (var prod in c.clientShopList)
            {
                Console.WriteLine($"-- {prod.Key} - {prod.Value}");
            }
            Console.WriteLine($"Bill: {c.Bill:f2}");
            totalBill += c.Bill;
        }
        Console.WriteLine($"Total bill: {totalBill:f2}");
    }
}

class Client
{
    public string Name { get; set; }

    public Dictionary<string, int> clientShopList { get; set; }

    public decimal Bill { get; set; }
}

