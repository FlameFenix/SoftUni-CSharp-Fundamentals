using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> crafting = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (crafting.ContainsKey(resource))
                {
                    crafting[resource] += quantity;
                }
                else
                {
                    crafting.Add(resource, quantity);
                }
            }

            foreach (var item in crafting)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
