using System;
using System.Linq;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLocation = Console.ReadLine()
                                           .Split(@"\", StringSplitOptions.RemoveEmptyEntries)
                                           .ToArray();

            string[] newFile = new string[2];

            newFile = fileLocation[fileLocation.Length - 1].Split(".");

            string fileName = newFile[0];
            string fileExtension = newFile[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
