using BorderControl.Interfaces;

namespace BorderControl.Models
{
    class Citizen : IUnit
    {
        private string name;
        private int age;


        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Id { get; }

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
    }
}

