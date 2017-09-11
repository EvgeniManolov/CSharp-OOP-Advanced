﻿using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(int id, string firstname, string lastname, double salary)
            : base(id, firstname, lastname, salary)
        {
            this.Privates = new List<IPrivate>();
        }

        public List<IPrivate> Privates { get; }

        public void AddPrivate(IPrivate priv)
        {
            this.Privates.Add(priv);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            result.AppendLine().AppendLine("Privates:");

            if (this.Privates.Count != 0)
            {
                string allPrivates = " " + string.Join(Environment.NewLine + " ", this.Privates);
                result.Append(allPrivates);
            }

            return result.ToString();
        }
    }
}

