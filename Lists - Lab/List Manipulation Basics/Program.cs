using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                   .Select(int.Parse)
                                                   .ToList();
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (true)
            {
                if (command[0].ToUpper() == "ADD")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0].ToUpper() == "REMOVE")
                {
                    numbers.Remove(int.Parse(command[1]));
                }
                else if (command[0].ToUpper() == "REMOVEAT")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0].ToUpper() == "INSERT")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                if (command[0].ToUpper() == "END")
                {
                    break;
                }
                command = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .ToArray();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
