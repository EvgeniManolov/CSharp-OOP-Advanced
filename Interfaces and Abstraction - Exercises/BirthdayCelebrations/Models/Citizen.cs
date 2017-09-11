using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations.Models
{
    public class Citizen : IUnit
    {
        public Citizen(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; }
        public string Birthdate { get; }
    }
}

