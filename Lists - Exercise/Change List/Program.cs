using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

            List<string> command = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToList();
            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers.Remove(int.Parse(command[1]));
                    }
                }
                if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }

                command = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
