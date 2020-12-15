using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());

            int numberTwo = int.Parse(Console.ReadLine());

            int numberThree = int.Parse(Console.ReadLine());

            SmallestNumber(numberOne, numberTwo, numberThree);

        }
        public static int SmallestNumber(int numberOne, int numberTwo, int numberThree)
        {
            int smallestNumber = 0;

            if (numberOne < numberTwo && numberOne < numberThree)
            {
                smallestNumber = numberOne;

            }

            else if (numberTwo < numberOne && numberTwo < numberThree)
            {

                smallestNumber = numberTwo;
            }

            else if (numberThree < numberTwo && numberThree < numberOne)
            {
                smallestNumber = numberThree;
            }

            else if (numberOne == numberTwo && numberOne < numberThree)
            {
                smallestNumber = numberOne;
            }
            else if (numberTwo == numberThree && numberTwo < numberOne)
            {
                smallestNumber = numberTwo;
            }
            else if (numberThree == numberOne && numberThree < numberTwo)
            {
                smallestNumber = numberThree;
            }
            else if (numberOne == numberTwo && numberTwo == numberThree && numberOne == numberThree)
            {
                smallestNumber = numberOne;
            }
            Console.WriteLine(smallestNumber);
            return smallestNumber;
        }
    }
}
