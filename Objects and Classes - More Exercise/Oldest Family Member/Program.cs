using System;
using System.Collections.Generic;
using System.Linq;

namespace Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);

                Person member = new Person(name, age);

                family.AddMember(member);
            }

            Console.WriteLine(family.GetOldestMember());
        }
    }

    class Family
    {
        private List<Person> peoples = new List<Person>();

        public void AddMember(Person person)
        {
            peoples.Add(person);
        }

        public Person GetOldestMember()
        {
            int maxAge = int.MinValue;
            string name = string.Empty;

            foreach (var person in peoples)
            {
                if(person.Age > maxAge)
                {
                    maxAge = person.Age;
                    name = person.Name;
                }
            }

            Person oldestPerson = peoples.Find(x => x.Name == name && x.Age == maxAge);

            return oldestPerson;
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
