using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();



            int[] condensed = new int[numbers.Length - 1];

            while (true)
            {
                if (numbers.Length == 1)
                {
                    break;
                }

                condensed = new int[numbers.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }

                numbers = condensed;



            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
