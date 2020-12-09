using System;

namespace _9._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());
            string word = one.ToString() + two.ToString() + three.ToString();
            Console.WriteLine($"{word}");
        }
    }
}
