using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                      .Select(double.Parse)
                                      .ToArray();
            foreach (var item in numbers)
            {
                double rounded = Math.Round(item, MidpointRounding.AwayFromZero);

                Console.WriteLine($"{item} => {rounded}");
            }
        }
    }
}
