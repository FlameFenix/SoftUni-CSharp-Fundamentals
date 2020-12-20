using System;
using System.Collections.Generic;
using System.Linq;

namespace Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that mixes up two lists by some rules.
            // You will receive two lines of input, each one being a list of numbers.The rules for mixing are:
            List<int> firstLine = Console.ReadLine()
                                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToList();

            List<int> secondLine = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToList();

            List<int> newLine = new List<int>();

            List<int> finalLine = new List<int>();

            int firstRange = 0;
            int secondRange = 0;

            //	Start from the beginning of the first list and from the ending of the second.

            //	Add element from the first and element from the second.

            //	At the end there will always be a list, in which there are 2 elements remaining.

            if (firstLine.Count > secondLine.Count)
            {
                for (int i = 0; i < secondLine.Count; i++)
                {
                    newLine.Add(firstLine[i]);
                    newLine.Add(secondLine[(secondLine.Count - 1) - i]);
                }

                firstRange = firstLine[firstLine.Count - 2];
                secondRange = firstLine[firstLine.Count - 1];

            }
            else if (firstLine.Count < secondLine.Count)
            {
                for (int i = 0; i < firstLine.Count; i++)
                {
                    newLine.Add(firstLine[i]);
                    newLine.Add(secondLine[(secondLine.Count - 1) - i]);
                }

                firstRange = secondLine[0];
                secondRange = secondLine[1];
            }


            //	These elements will be the range of the elements you need to print.
            //	Loop through the result list and take only the elements that fulfill the condition.

            newLine.Sort();
            if(firstRange < secondRange)
            {
                for (int i = 0; i < newLine.Count; i++)
                {
                    if (newLine[i] > firstRange && newLine[i] < secondRange)
                    {
                        finalLine.Add(newLine[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < newLine.Count; i++)
                {
                    if (newLine[i] > secondRange && newLine[i] < firstRange)
                    {
                        finalLine.Add(newLine[i]);
                    }
                }
            }
            

            Console.WriteLine(string.Join(" ", finalLine));
            //	Print the elements ordered in ascending order and separated by a space.

        }
    }
}
