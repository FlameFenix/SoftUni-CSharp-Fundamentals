using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                 .Select(int.Parse)
                                                 .ToList();

            List<int> specialNumbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();


            while (numbers.Contains(specialNumbers[0]))
            {

                int currentIndex = numbers.IndexOf(specialNumbers[0]);

                int leftNumbers = currentIndex - specialNumbers[1];
                int rightNumbers = currentIndex + specialNumbers[1];

                if (leftNumbers < 0)
                {
                    leftNumbers = 0;
                }

                if (rightNumbers > numbers.Count - 1)
                {
                    rightNumbers = numbers.Count - 1;
                }

                int removeCount = (rightNumbers - leftNumbers) + 1;

                numbers.RemoveRange(leftNumbers, removeCount);
            }


            Console.WriteLine(numbers.Sum());
        }
    }
}
