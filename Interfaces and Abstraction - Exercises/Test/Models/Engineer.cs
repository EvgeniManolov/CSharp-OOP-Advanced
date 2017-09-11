using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(int id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary, corps)
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
        var result = new StringBuilder();

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

