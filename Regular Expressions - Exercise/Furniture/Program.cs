using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            string pattern = @">>(?<object>[A-Za-z]+)<<(?<price>\d+.?\d*)!(?<quantity>\d+)";

            List<string> boughtObjects = new List<string>();

            double moneySpend = 0;

            Regex regex = new Regex(pattern);

            Console.WriteLine("Bought furniture:");

            while (command != "Purchase")
            {

                Match matches = regex.Match(command);

                if (matches.Success)
                {
                    string item = matches.Groups["object"].Value;
                    double price = double.Parse(matches.Groups["price"].Value);
                    int quantity = int.Parse(matches.Groups["quantity"].Value);

                    moneySpend += quantity * price;
                    boughtObjects.Add(item);
                    Console.WriteLine(item);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {moneySpend:f2}");
        }
    }
}
