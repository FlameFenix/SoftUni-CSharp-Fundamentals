using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>(numberOfOperations);

            List<string> outputs = new List<string>(numberOfOperations);

            for (int i = 0; i < numberOfOperations; i++)
            {
                List<string> command = Console.ReadLine()
                                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                             .ToList();



                if (command.Count == 3)
                {
                    if (guests.Contains(command[0]))
                    {
                        outputs.Add($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(command[0]);
                    }
                }
                else if (command.Count == 4)
                {
                    if (guests.Contains(command[0]))
                    {
                        guests.Remove(command[0]);
                    }
                    else
                    {
                        outputs.Add($"{command[0]} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, outputs));
            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}
