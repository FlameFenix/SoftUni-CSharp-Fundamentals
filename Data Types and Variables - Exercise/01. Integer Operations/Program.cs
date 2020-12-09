using System;

namespace _01_Integer_Operations_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());
            int sumOfAll = ((numberOne + numberTwo) / numberThree) * numberFour;
            Console.WriteLine(sumOfAll);
        }
    }
}
