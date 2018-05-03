using System;
using System.Collections.Generic;
using System.Numerics;

class p01_AnonymousDownsite
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int securityKey = int.Parse(Console.ReadLine());

        BigInteger securityToken = BigInteger.Pow(securityKey, n);
        decimal result = 0;

        List<string> sites = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string siteName = input[0];
            decimal siteVisits = decimal.Parse(input[1]);
            decimal PPV = decimal.Parse(input[2]);

            sites.Add(siteName);

            result += siteVisits * PPV;
        }

        Console.WriteLine(string.Join(Environment.NewLine, sites));
        Console.WriteLine($"Total Loss: {result:F20}");
        Console.WriteLine($"Security Token: {securityToken}");
    }
}

