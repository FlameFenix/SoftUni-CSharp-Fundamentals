using System;
using System.Linq;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ")
                                          .Select(int.Parse)
                                          .ToArray();
            int even = 0;
            int odd = 0;
            int sum = 0;
            foreach (var element in arr)
            {
                if (element % 2 == 0)
                {
                    even += element;
                }
                else if (element % 2 == 1)
                {
                    odd += element;
                }
            }
            sum = even - odd;
            Console.WriteLine(sum);
        }
    }
}
