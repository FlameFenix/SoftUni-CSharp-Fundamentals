using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int numberTwo = int.Parse(Console.ReadLine());
            if (operation == "/")
            {
                Divide(numberOne, numberTwo);
            }
            else if (operation == "*")
            {
                Multiply(numberOne, numberTwo);
            }
            else if (operation == "+")
            {
                Sum(numberOne, numberTwo);
            }
            else if (operation == "-")
            {
                Subtract(numberOne, numberTwo);
            }
        }
        public static void Multiply(int numberOne, int numberTwo)
        {
            int sum = numberOne * numberTwo;
            Console.WriteLine($"{sum}");
        }
        public static void Divide(int numberOne, int numberTwo)
        {
            int sum = numberOne / numberTwo;
            Console.WriteLine($"{sum}");
        }

        public static void Sum(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;
            Console.WriteLine($"{sum}");
        }

        public static void Subtract(int numberOne, int numberTwo)
        {
            int sum = numberOne - numberTwo;
            Console.WriteLine($"{sum}");
        }
    }
}
