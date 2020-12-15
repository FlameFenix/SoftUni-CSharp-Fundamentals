using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToList();

            int limitation = int.Parse(Console.ReadLine());

            List<string> command = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToList();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (int.Parse(command[0]) + wagons[i] <= limitation)
                        {
                            wagons[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }

                command = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .ToList();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
