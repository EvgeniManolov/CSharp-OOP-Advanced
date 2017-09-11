using System;

public class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    private string corps;
    public SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    public string Corps
    {
        get { return this.corps; }

        set
        {
            if (!value.Equals("Airforces") && !value.Equals("Marines"))
            {
                throw new InvalidOperationException();
            }

            this.corps = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"{Environment.NewLine}Corps: {this.Corps}";
    }
}

