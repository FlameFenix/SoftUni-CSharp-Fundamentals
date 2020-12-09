using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                bool isBigger = true;
                int currentInt = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] >= currentInt)
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger)
                {
                    Console.Write($"{currentInt} ");
                }
            }
        }
    }
}
