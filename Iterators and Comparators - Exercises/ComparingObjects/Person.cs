using System;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public string Town
        {
            get { return this.town; }
            private set { this.town = value; }
        }

        public int CompareTo(Person other)
        {
            if (this.Name == other.Name)
            {
                if (this.Age == other.Age)
                {
                    if (this.Town == other.Town)
                    {
                        return 0;
                    }
                }
            }
            return -1;
        }
    }
}

