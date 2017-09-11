using ExplicitInterfaces.Interfaces;

namespace ExplicitInterfaces.Models
{
    public class Citizen : IPerson, IResident
    {

        public Citizen(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }

        public int Age { get; }

        public string Country { get; }

        public string Name { get; }

        string IResident.GetName()
        {
            return "Mr/Ms/Mrs " + this.Name;
        }

        string IPerson.GetName()
        {
            return this.Name;
        }
    }
}
