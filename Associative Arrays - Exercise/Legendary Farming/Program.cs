using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] materials = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            Dictionary<string, int> legendaryItems = new Dictionary<string, int>();

            legendaryItems.Add("fragments", 0);
            legendaryItems.Add("shards", 0);
            legendaryItems.Add("motes", 0);

            Dictionary<string, int> junkItems = new Dictionary<string, int>();

            bool isLegendaryItemFound = false;

            while (true)
            {
                for (int i = 0; i < materials.Length; i += 2)
                {
                    int quantity = int.Parse(materials[i]);
                    string element = materials[i + 1];

                    if (element.ToLower() == "shards" || element.ToLower() == "fragments" || element.ToLower() == "motes")
                    {
                        if (legendaryItems.ContainsKey(element.ToLower()))
                        {
                            legendaryItems[element.ToLower()] += quantity;
                        }

                        if (legendaryItems[element.ToLower()] >= 250)
                        {
                            string legendaryItem = string.Empty;

                            if (element.ToLower() == "fragments")
                            {
                                legendaryItem = "Valanyr";
                            }
                            else if (element.ToLower() == "shards")
                            {
                                legendaryItem = "Shadowmourne";
                            }
                            else if (element.ToLower() == "motes")
                            {
                                legendaryItem = "Dragonwrath";
                            }

                            Console.WriteLine($"{legendaryItem} obtained!");

                            legendaryItems[element.ToLower()] -= 250;
                            isLegendaryItemFound = true;
                            break;
                        }
                    }
                    else
                    {
                        if (junkItems.ContainsKey(element.ToLower()))
                        {
                            junkItems[element.ToLower()] += quantity;
                        }
                        else
                        {
                            junkItems.Add(element.ToLower(), quantity);
                        }
                    }


                }
                if (isLegendaryItemFound)
                {
                    break;
                }
                materials = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            foreach (var item in legendaryItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkItems.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
