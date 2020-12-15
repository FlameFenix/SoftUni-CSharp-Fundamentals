using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int numberOfProducts = int.Parse(Console.ReadLine());
            Bill(product, numberOfProducts);
        }

        static void Bill(string product, int numOfProducts)
        {
            double price = 0;
            if (product == "coffee")
            {
                price = 1.50 * numOfProducts;
            }
            else if (product == "water")
            {
                price = 1.00 * numOfProducts;
            }
            else if (product == "coke")
            {
                price = 1.40 * numOfProducts;
            }
            else if (product == "snacks")
            {
                price = 2.00 * numOfProducts;
            }
            Console.WriteLine($"{price:f2}");
        }

    }

}
