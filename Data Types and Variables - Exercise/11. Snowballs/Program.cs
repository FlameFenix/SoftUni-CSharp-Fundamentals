using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOpearations = int.Parse(Console.ReadLine());
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;
            BigInteger bestSnowball = 0;
            for (int i = 0; i < numberOfOpearations; i++)
            {
                 int snowballSnow = int.Parse(Console.ReadLine());
                 int snowballTime = int.Parse(Console.ReadLine());
                 int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > bestSnowball)
                {
                    bestSnowball = snowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballQuality = snowballQuality;
                    bestSnowballTime = snowballTime;
                }

            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowball} ({bestSnowballQuality})");
        }
    }
}
