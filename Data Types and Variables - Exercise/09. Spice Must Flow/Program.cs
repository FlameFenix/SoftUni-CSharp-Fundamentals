using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int source = int.Parse(Console.ReadLine());
            int spiceEarned = 0;
            int countDays = 0;
            while(source >= 100)
            {
                countDays++;
                spiceEarned += source - 26;
                source -= 10;
            }
            if(spiceEarned >= 26)
            {
                spiceEarned -= 26;
            }
            Console.WriteLine(countDays);
            Console.WriteLine(spiceEarned);
        }
    }
}
