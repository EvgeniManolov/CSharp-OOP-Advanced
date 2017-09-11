using MilitaryElite.Factory;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<ISoldier> army = new List<ISoldier>();

            while (input != "End")
            {
                try
                {
                    army.Add(SoldierFactory.ProduceSoldier(input));
                }
                catch (Exception)
                {
                }

                input = Console.ReadLine();
            }

            foreach (ISoldier soldier in army)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
