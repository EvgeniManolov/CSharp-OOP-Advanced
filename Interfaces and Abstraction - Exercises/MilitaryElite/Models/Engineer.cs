using MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstname, string lastname, double salary, string corps)
            : base(id, firstname, lastname, salary, corps)
        {
            this.Repairs = new List<IRepair>();
        }

        public List<IRepair> Repairs { get; }

        public void AddRepair(IRepair rep)
        {
            this.Repairs.Add(rep);
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(base.ToString());
            result.Append("Repairs:");

            if (this.Repairs.Count != 0)
            {
                result.AppendLine()
                    .Append(string.Join("\n", this.Repairs));
            }

            return result.ToString();
        }
    }
}

