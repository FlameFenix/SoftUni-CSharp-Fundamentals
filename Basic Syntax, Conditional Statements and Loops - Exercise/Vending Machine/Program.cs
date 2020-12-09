using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double coinsSum = 0;
            while (command != "Start")
            {
                double coin = double.Parse(command);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1.0 || coin == 2.0)
                {
                    coinsSum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                command = Console.ReadLine();
                if (command == "Start")
                {
                    string product = Console.ReadLine();
                    string output = string.Empty;
                    double productPrice = 0;
                    while (product != "End")
                    {
                        if (product == "Nuts")
                        {
                            productPrice = 2.0;
                        }
                        else if (product == "Water")
                        {
                            productPrice = 0.7;
                        }
                        else if (product == "Crisps")
                        {
                            productPrice = 1.5;
                        }
                        else if (product == "Soda")
                        {
                            productPrice = 0.8;
                        }
                        else if (product == "Coke")
                        {
                            productPrice = 1.0;
                        }
                        else
                        {
                            Console.WriteLine("Invalid product");
                            product = Console.ReadLine();
                            continue;
                        }
                        if (coinsSum >= productPrice)
                        {
                            coinsSum -= productPrice;
                            Console.WriteLine($"Purchased {product.ToLower()}");

                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        product = Console.ReadLine();
                    }
                    Console.WriteLine($"Change: {coinsSum:f2}");
                }

            }
        }
    }
}
