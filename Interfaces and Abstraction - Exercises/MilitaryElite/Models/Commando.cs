using MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstname, string lastname, double salary, string corps)
            : base(id, firstname, lastname, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public List<IMission> Missions { get; }

        public void AddMission(IMission mission)
        {
            this.Missions.Add(mission);
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(base.ToString());
            result.Append("Missions:");
            if (this.Missions.Count != 0)
            {
                result.AppendLine()
                    .Append(string.Join("\n", this.Missions));
            }

            return result.ToString();
        }
    }
}

