using System;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstname, string lastname, int codeNumber) : base(id, firstname, lastname)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Code Number: {this.CodeNumber}";
        }
    }
}
