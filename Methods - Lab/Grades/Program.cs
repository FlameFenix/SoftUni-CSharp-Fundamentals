using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);

            static void PrintGrade(double grade)
            {
                string output = string.Empty;
                if (grade >= 2.00 && grade <= 2.99)
                {
                    output = "Fail";
                }
                else if (grade > 2.99 && grade <= 3.49)

                {
                    output = "Poor";
                }
                else if (grade > 3.49 && grade <= 4.49)
                {
                    output = "Good";
                }
                else if (grade > 4.49 && grade <= 5.49)
                {
                    output = "Very good";
                }
                else if (grade > 5.49 && grade <= 6.00)
                {
                    output = "Excellent";
                }
                Console.WriteLine(output);
            }
        }
    }
}
