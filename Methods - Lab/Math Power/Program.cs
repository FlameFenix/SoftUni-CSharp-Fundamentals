using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Power(number, power);
        }

        static void Power(double number, int power)
        {
            Console.WriteLine(Math.Pow(number, power));
        }
    }
}
