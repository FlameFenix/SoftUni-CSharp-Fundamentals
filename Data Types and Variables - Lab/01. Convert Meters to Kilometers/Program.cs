using System;

namespace _01_Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            decimal distanceInKilometers = distanceInMeters / 1000M;
            Console.WriteLine($"{distanceInKilometers:f2}");
        }
    }
}
