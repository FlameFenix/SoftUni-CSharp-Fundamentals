using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            List<Box> products = new List<Box>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                // {Serial Number} {Item Name} {Item Quantity} {itemPrice}

                Box boxes = new Box();
                boxes.Item = new Item();

                int serialNum = int.Parse(cmdArgs[0]);
                string itemName = cmdArgs[1];
                int itemQuantity = int.Parse(cmdArgs[2]);
                double itemPrice = double.Parse(cmdArgs[3]);
                boxes.Item.Name = itemName;
                boxes.Item.Price = itemPrice;
                boxes.SerialNumber = serialNum;
                boxes.itemQuantity = itemQuantity;
                boxes.priceForBox = itemQuantity * itemPrice;

                products.Add(boxes);
            }

            foreach (var item in products.OrderByDescending(x => x.priceForBox))
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.Item.Name} - ${item.Item.Price:f2}: {item.itemQuantity}");
                Console.WriteLine($"-- ${item.priceForBox:f2}");
            }
        }
    }
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        // Serial Number, Item, Item Quantity and Price for a Box.

        public Box()
        {
            Item = new Item();
        }
        public int SerialNumber { get; set; }

        public Item Item { get; set; }
        public int itemQuantity { get; set; }
        public double priceForBox { get; set; }
    }
}
