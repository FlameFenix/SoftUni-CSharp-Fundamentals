using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();

            string[] products = Console.ReadLine()
                                       .Split()
                                       .ToArray();

            string product = string.Empty;

            while (product != "buy")
            {
                product = products[0];

                double productPrice = double.Parse(products[1]);
                double productLitters = double.Parse(products[2]);
                if (!orders.ContainsKey(product))
                {
                    orders.Add(product, new List<double>() { productPrice, productLitters });
                }
                else
                {
                    orders[product][0] = productPrice;
                    orders[product][1] += productLitters;
                }

                products = Console.ReadLine()
                                  .Split()
                                  .ToArray();

                product = products[0];

            }

            foreach (var item in orders)
            {
                double sumOfProducts = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {sumOfProducts:f2}");
            }
        }
    }
}
