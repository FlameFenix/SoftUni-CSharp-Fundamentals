﻿using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reverseWord = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord += word[i];
            }

            Console.WriteLine(reverseWord);
        }
    }
}
