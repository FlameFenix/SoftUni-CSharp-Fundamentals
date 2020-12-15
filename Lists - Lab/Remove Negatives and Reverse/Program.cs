using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                 .Select(int.Parse)
                                                 .ToList();

            List<int> withoutNegativeNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    withoutNegativeNumbers.Add(numbers[i]);
                }
            }
            withoutNegativeNumbers.Reverse();
            if (withoutNegativeNumbers.Count != 0)
            {
                Console.WriteLine(string.Join(" ", withoutNegativeNumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
