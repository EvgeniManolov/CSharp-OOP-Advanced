using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstname, string lastname, double salary) : base(id, firstname, lastname)
        {
            this.Salary = salary;
        }

        public double Salary { get; }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {this.Salary:F2}";
        }
    }
}

