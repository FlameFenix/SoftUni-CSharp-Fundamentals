using System;

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOperations; i++)
            {
                string input = Console.ReadLine();

                int nameIndex = input.IndexOf("@");
                int nameEndIndex = input.IndexOf("|");
                nameEndIndex = nameEndIndex - nameIndex;

                int ageIndex = input.IndexOf("#");
                int ageEndIndex = input.IndexOf("*");
                ageEndIndex = ageEndIndex - ageIndex;

                string name = input.Substring(nameIndex + 1, nameEndIndex - 1);
                string age = input.Substring(ageIndex + 1, ageEndIndex - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
