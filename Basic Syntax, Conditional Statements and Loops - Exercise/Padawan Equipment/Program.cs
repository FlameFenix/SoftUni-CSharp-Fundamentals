using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightSabersTenPercent = Math.Ceiling(numberOfStudents * 1.10);
            double freeBelts = Math.Floor(numberOfStudents / 6.0);
            double sumLightsabers = lightSabersTenPercent * lightsabersPrice;
            double sumRobes = robesPrice * numberOfStudents;
            double sumBelts = beltsPrice * (numberOfStudents - freeBelts);

            double costs = sumLightsabers + sumRobes + sumBelts;
            if (budget >= costs)
            {
                Console.WriteLine($"The money is enough - it would cost {costs:f2}lv.");
            }
            else
            {
                costs -= budget;
                Console.WriteLine($"Ivan Cho will need {costs:f2}lv more.");
            }
        }
    }
}
