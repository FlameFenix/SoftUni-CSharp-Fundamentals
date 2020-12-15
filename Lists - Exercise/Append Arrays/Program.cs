using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                                          .Split("|", StringSplitOptions.RemoveEmptyEntries)
                                          .Reverse()
                                          .ToList();

            string result = string.Empty;

            List<int> FINAL = new List<int>().ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                List<string> newOrder = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                  .ToList();

                for (int j = 0; j < newOrder.Count; j++)
                {
                    FINAL.Add(int.Parse(newOrder[j]));
                }

            }

            Console.WriteLine(string.Join(" ", FINAL));
        }
    }
}
