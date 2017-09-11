using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int workHours)
        {
            this.PartName = partName;
            this.WorkHours = workHours;
        }
        public string PartName { get; }

        public int WorkHours { get; }
        public override string ToString()
        {
            return $"  Part Name: {this.PartName} Hours Worked: {this.WorkHours}";
        }
    }
}

