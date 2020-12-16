using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> studentsList = new List<Students>();



            string[] input = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            while (input[0] != "end")
            {
                Students newStudent = new Students();

                bool isStudentExist = false;

                newStudent.firstName = input[0];
                newStudent.lastName = input[1];
                newStudent.age = int.Parse(input[2]);
                newStudent.homeTown = input[3];

                foreach (var item in studentsList)
                {
                    if (item.firstName == newStudent.firstName && item.lastName == newStudent.lastName)
                    {
                        item.age = newStudent.age;
                        item.homeTown = newStudent.homeTown;
                        isStudentExist = true;
                    }

                }
                if (!isStudentExist)
                {
                    studentsList.Add(newStudent);
                }

                input = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .ToArray();
            }

            string currentCity = Console.ReadLine();

            foreach (var item in studentsList)
            {
                if (item.homeTown == currentCity)
                {
                    Console.WriteLine($"{item.firstName} {item.lastName} is {item.age} years old.");
                }
            }
        }
    }

    class Students
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public int age { get; set; }

        public string homeTown { get; set; }
    }
}
