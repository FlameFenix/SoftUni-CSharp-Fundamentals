using System;
using System.Collections.Generic;
using System.Linq;

namespace Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            List<double> drums = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(double.Parse)
                                        .ToList();

            List<double> drumsBasicValue = new List<double>();

            for (int i = 0; i < drums.Count; i++)
            {
                drumsBasicValue.Add(drums[i]);
            }

            string command = string.Empty;
            bool isBudgetEnough = budget > 0;
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {

                double hitPower = double.Parse(command);

                for (int i = 0; i < drums.Count; i++)
                {
                        drums[i] -= hitPower;

                        if (drums[i] <= 0)
                        {
                            if (budget - (drumsBasicValue[i] * 3) >= 0)
                            {
                                drums[i] = drumsBasicValue[i];

                                budget -= (drums[i] * 3);
                            }
                            else
                            {
                                drums.Remove(drums[i]);
                                drumsBasicValue.Remove(drumsBasicValue[i]);
                            i = i - 1;
                            }
                        }
                    
                }

            }
            Console.WriteLine(string.Join(" ", drums));
            Console.WriteLine($"Gabsy has {budget:f2}lv.");
        }
    }
}
