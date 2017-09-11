using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public abstract class Soldier : ISoldier
    {
        protected Soldier(int id, string firstname, string lastname)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
        }

        public string Firstname { get; }

        public int Id { get; }

        public string Lastname { get; }

        public override string ToString()
        {
            return $"Name: {this.Firstname} {this.Lastname} Id: {this.Id}";
        }
    }
}
