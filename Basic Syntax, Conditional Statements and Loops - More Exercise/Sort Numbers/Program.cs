using System;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            if(numberOne > numberTwo && numberOne > numberThree)
            {
                Console.WriteLine(numberOne);
                if(numberTwo > numberThree)
                {
                    Console.WriteLine(numberTwo);
                    Console.WriteLine(numberThree);
                }
                else
                {
                    Console.WriteLine(numberThree);
                    Console.WriteLine(numberTwo);
                }
            }
            else if(numberTwo > numberOne && numberTwo > numberThree)
            {
                Console.WriteLine(numberTwo);
                if(numberOne > numberThree)
                {
                    Console.WriteLine(numberOne);
                    Console.WriteLine(numberThree);
                }
                else
                {
                    Console.WriteLine(numberThree);
                    Console.WriteLine(numberOne);
                }
            }
            else if(numberThree > numberTwo && numberThree > numberOne)
            {
                Console.WriteLine(numberThree);
                if(numberOne > numberTwo)
                {
                    Console.WriteLine(numberOne);
                    Console.WriteLine(numberTwo);
                }
                else
                {
                    Console.WriteLine(numberTwo);
                    Console.WriteLine(numberOne);
                }
            }
        }
    }
}
