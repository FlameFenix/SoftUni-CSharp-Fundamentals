using System;

namespace Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumberEven = true;
            while (isNumberEven)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    isNumberEven = false;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
