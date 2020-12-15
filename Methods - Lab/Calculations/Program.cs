using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string function = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            if (function == "add")
            {
                Add(numberOne, numberTwo);
            }
            else if (function == "subtract")
            {
                Subtract(numberOne, numberTwo);
            }
            else if (function == "divide")
            {
                Divide(numberOne, numberTwo);
            }
            else if (function == "multiply")
            {
                Multiply(numberOne, numberTwo);
            }
        }

        static void Add(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne + numberTwo);
        }
        static void Multiply(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne * numberTwo);
        }
        static void Divide(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne / numberTwo);
        }
        static void Subtract(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne - numberTwo);
        }

    }
}
