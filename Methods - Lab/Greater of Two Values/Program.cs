using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            if (type == "int")
            {
                GetMaxInt(type);
            }
            else if (type == "char")
            {
                GetMaxChar(type);
            }
            else if (type == "string")
            {
                GetMaxString(type);
            }
        }

        static void GetMaxInt(string type)
        {
            string output = string.Empty;
            if (type == "int")
            {
                int numberOne = int.Parse(Console.ReadLine());
                int numberTwo = int.Parse(Console.ReadLine());
                if (numberOne > numberTwo)
                {
                    output = $"{numberOne}";
                }
                else if (numberTwo > numberOne)
                {
                    output = $"{numberTwo}";
                }
                else
                {
                    output = $"{numberOne}";
                }
                Console.WriteLine(output);
            }
        }
        static void GetMaxChar(string type)
        {
            string output = string.Empty;

            if (type == "char")
            {
                char letterOne = char.Parse(Console.ReadLine());
                char letterTwo = char.Parse(Console.ReadLine());
                if (letterOne > letterTwo)
                {
                    output = $"{letterOne}";
                }
                else if (letterTwo > letterOne)
                {
                    output = $"{letterTwo}";
                }
                else
                {
                    output = $"{letterOne}";
                }
                Console.WriteLine(output);
            }
        }
        static void GetMaxString(string type)
        {
            string output = string.Empty;
            if (type == "string")
            {
                string wordOne = Console.ReadLine();
                string wordTwo = Console.ReadLine();

                if (wordOne.CompareTo(wordTwo) >= 0)
                {
                    output = $"{wordOne}";
                }
                else
                {
                    output = $"{wordTwo}";
                }
            }
            Console.WriteLine(output);
        }
    }
}
