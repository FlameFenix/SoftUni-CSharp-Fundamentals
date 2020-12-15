using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
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

            List<string> invalidIndex = new List<string>();

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    if ((int.Parse(command[2]) >= 0) &&
                       (int.Parse(command[2]) <= numbers.Count - 1))
                    {
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }


                }
                else if (command[0] == "Remove")
                {
                    if ((int.Parse(command[1]) >= 0) &&
                       (int.Parse(command[1]) <= numbers.Count - 1))
                    {
                        numbers.RemoveAt(int.Parse(command[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
                else if (command[0] == "Shift")
                {
                    int loopOperations = int.Parse(command[2]);
                    if (command[1] == "left")
                    {
                        for (int i = 0; i < loopOperations; i++)
                        {
                            int firstNumber = numbers[0];
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = firstNumber;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < loopOperations; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];
                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }
                            numbers[0] = lastNumber;
                        }
                    }

                }
                command = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToList();

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
