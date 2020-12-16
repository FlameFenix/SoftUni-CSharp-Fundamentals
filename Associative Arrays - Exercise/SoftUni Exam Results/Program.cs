using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmdArgs = Console.ReadLine();

            string[] students = cmdArgs.Split("-", StringSplitOptions.RemoveEmptyEntries)
                                       .ToArray();
            Dictionary<string, int> studentsAndPoints = new Dictionary<string, int>();

            Dictionary<string, int> coursesAndParticipants = new Dictionary<string, int>();

            while (cmdArgs != "exam finished")
            {
                string username = students[0];

                string language = students[1];

                int points = 0;

                if (language != "banned")
                {
                    points = int.Parse(students[2]);
                }
                else
                {
                    if (studentsAndPoints.ContainsKey(username))
                    {
                        studentsAndPoints.Remove(username);
                        cmdArgs = Console.ReadLine();
                        students = cmdArgs.Split("-", StringSplitOptions.RemoveEmptyEntries)
                                           .ToArray();
                        continue;
                    }
                }


                if (studentsAndPoints.ContainsKey(username))
                {

                    if (studentsAndPoints[username] < points)
                    {
                        studentsAndPoints[username] = points;
                    }

                    coursesAndParticipants[language]++;

                }
                else
                {
                    studentsAndPoints.Add(username, points);
                    if (coursesAndParticipants.ContainsKey(language))
                    {
                        coursesAndParticipants[language]++;
                    }
                    else
                    {
                        coursesAndParticipants.Add(language, 1);
                    }

                }

                cmdArgs = Console.ReadLine();
                students = cmdArgs.Split("-", StringSplitOptions.RemoveEmptyEntries)
                                   .ToArray();
            }

            Console.WriteLine("Results:");
            foreach (var item in studentsAndPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in coursesAndParticipants.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
