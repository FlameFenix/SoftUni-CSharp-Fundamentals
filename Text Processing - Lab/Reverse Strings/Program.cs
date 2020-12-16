using System;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string reverse = string.Empty;
                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reverse += command[i];
                }

                Console.WriteLine($"{command} = {reverse}");
            }
        }
    }
}
