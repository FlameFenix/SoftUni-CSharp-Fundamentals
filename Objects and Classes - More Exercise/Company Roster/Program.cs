using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                string name = cmdArgs[0];
                double salary = double.Parse(cmdArgs[1]);
                string department = cmdArgs[2];

                Employee employee = new Employee(name, salary, department);

                employeeList.Add(employee);

            }

            double highestSalary = 0;
            string highestDepartment = string.Empty;

            Dictionary<string, List<double>> departmentsList = new Dictionary<string, List<double>>();

            foreach (var item in employeeList)
            {
                double salary = item.Salary;
                string department = item.Department;
                if (!departmentsList.ContainsKey(department))
                {
                    departmentsList.Add(department, new List<double>());
                }

                departmentsList[department].Add(salary);
            }

            foreach (var item in departmentsList)
            {
                if (item.Value.Average() > highestSalary)
                {
                    highestSalary = item.Value.Average();
                    highestDepartment = item.Key;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestDepartment}");

            foreach (var item in employeeList.OrderByDescending(x => x.Salary))
            {
                if(item.Department == highestDepartment)
                {
                    Console.WriteLine($"{item.Name} {item.Salary:f2}");
                }
            }

        }

    }

    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }

        public string Name { get; set; }

        public double Salary { get; set; }

        public string Department { get; set; }
    }
}
