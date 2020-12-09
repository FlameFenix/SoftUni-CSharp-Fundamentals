using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] people = new int[numberOfWagons];
            for (int i = 0; i < numberOfWagons; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{string.Join(" ", people)}");
            Console.WriteLine($"{people.Sum()}");
        }
    }
}
