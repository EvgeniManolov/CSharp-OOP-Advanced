using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> collectionOfPerson = new List<Person>();
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                string[] tokens = inputLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];
                collectionOfPerson.Add(new Person(name, age, town));
            }

            int indexOfPerson = int.Parse(Console.ReadLine());
            Person comparedPerson = collectionOfPerson[indexOfPerson - 1];

            int matches = 0;
            foreach (Person person in collectionOfPerson)
            {
                int result = person.CompareTo(comparedPerson);
                if (result == 0)
                {
                    matches++;
                }
            }

            if (matches == 1 || matches == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {collectionOfPerson.Count - matches } {collectionOfPerson.Count}");
            }
        }
    }
}
