using System;
using System.Diagnostics;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            short littresWater = 0;
            for (int i = 0; i < numberOfOperations; i++)
            {
                short litres = short.Parse(Console.ReadLine());

                bool isTankFull = littresWater + litres > 255;
                if(isTankFull)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    littresWater += litres ;
                }

            }
            Console.WriteLine(littresWater);
        }
    }
}
