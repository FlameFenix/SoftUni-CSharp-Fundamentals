using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceTarget = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int countPokedTargets = 0;
            double pokePowerInPercentage = pokePower * 0.50;
            if(pokePower > 0)
            {
                while (pokePower >= distanceTarget)
                {
                    countPokedTargets++;
                    pokePower -= distanceTarget;
                    if ((int)pokePowerInPercentage == pokePower && exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
                Console.WriteLine(pokePower);
                Console.WriteLine(countPokedTargets);
            }

        }
    }
}
