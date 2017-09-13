using System;
using StrategyPattern.Comparators;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class StartUp
    {
        public static void Main()
        {
            SortedSet<Person> sortedPeopleByName = new SortedSet<Person>(new NameComparator());
            SortedSet<Person> sortedPeopleByAge = new SortedSet<Person>(new AgeComparator());

            int countPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < countPeople; i++)
            {
                string[] tokensPeople = Console.ReadLine().Split();
                string name = tokensPeople[0];
                int age = int.Parse(tokensPeople[1]);
                Person person = new Person(name, age);
                sortedPeopleByName.Add(person);
                sortedPeopleByAge.Add(person);
            }

            foreach (Person person in sortedPeopleByName)
            {
                Console.WriteLine(person);
            }

            foreach (Person person in sortedPeopleByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}

