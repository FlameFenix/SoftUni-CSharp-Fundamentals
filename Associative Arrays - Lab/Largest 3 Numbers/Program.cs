using System;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < 3)
                {
                    Console.Write($"{numbers[i]} ");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
