using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            Sum(numberOne, numberTwo, numberThree);
        }

        public static void Sum(int numberOne, int numberTwo, int numberThree)
        {
            int sum = (numberOne + numberTwo) - numberThree;
            Console.WriteLine(sum);
        }
    }
}
