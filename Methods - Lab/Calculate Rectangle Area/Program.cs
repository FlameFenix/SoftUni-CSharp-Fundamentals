using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            Rectangle(width, length);
        }
        static void Rectangle(double width, double length)
        {
            double result = width * length;
            Console.WriteLine($"{result}");
        }
    }
}
