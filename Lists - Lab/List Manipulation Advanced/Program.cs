using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
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

            List<string> outputs = new List<string>();

            bool isChanged = false;
            while (true)
            {
                if (command[0].ToUpper() == "ADD")
                {
                    isChanged = true;
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0].ToUpper() == "REMOVE")
                {
                    isChanged = true;
                    numbers.Remove(int.Parse(command[1]));
                }
                else if (command[0].ToUpper() == "REMOVEAT")
                {
                    isChanged = true;
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0].ToUpper() == "INSERT")
                {
                    isChanged = true;
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }

                else if (command[0].ToUpper() == "CONTAINS")
                {
                    if (numbers.Contains(int.Parse(command[1])) == true)
                    {
                        outputs.Add("Yes");
                    }
                    else
                    {
                        outputs.Add("No such number");
                    }
                }
                else if (command[0].ToUpper() == "PRINTEVEN")
                {
                    outputs.Add(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (command[0].ToUpper() == "PRINTODD")
                {
                    outputs.Add(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (command[0].ToUpper() == "GETSUM")
                {
                    outputs.Add(numbers.Sum().ToString());
                }
                else if (command[0].ToUpper() == "FILTER")
                {

                    string result = string.Empty;
                    if (command[1] == ">")
                    {

                        outputs.Add(string.Join(" ", numbers.Where(x => x > int.Parse(command[2]))));
                    }
                    else if (command[1] == ">=")
                    {
                        outputs.Add(string.Join(" ", numbers.Where(x => x >= int.Parse(command[2]))));
                    }
                    else if (command[1] == "<")
                    {
                        outputs.Add(string.Join(" ", numbers.Where(x => x < int.Parse(command[2]))));
                    }
                    else if (command[1] == "<=")
                    {
                        outputs.Add(string.Join(" ", numbers.Where(x => x <= int.Parse(command[2]))));
                    }

                }
                if (command[0].ToUpper() == "END")
                {
                    break;
                }
                command = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .ToArray();
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
                Console.WriteLine(string.Join(Environment.NewLine, outputs));
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, outputs));
            }
        }
    }
}
