using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            List<People> Peoples = new List<People>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();
                string name = cmdArgs[0];
                int id = int.Parse(cmdArgs[1]);
                int age = int.Parse(cmdArgs[2]);

                People people = new People(name, id, age);

                Peoples.Add(people);
            }

            foreach (var item in Peoples.OrderBy(x => x.Age))
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    class People
    {
        public People(string name, int id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
