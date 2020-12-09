using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ")
                                          .Select(int.Parse)
                                          .ToArray();
            int currentNumber = 0;
            foreach (var element in arr)
            {
                if (element % 2 == 0)
                {
                    currentNumber += element;
                }
            }
            Console.WriteLine(currentNumber);
        }
    }
}
