using System;
using System.Collections.Generic;
using System.Linq;
using BorderControl.Interfaces;
using BorderControl.Models;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<IUnit> units = new List<IUnit>();

            while (input != "End")
            {
                string[] tokens = input.Split();
                if (tokens.Length == 3)
                {
                    units.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
                else
                {
                    units.Add(new Robot(tokens[0], tokens[1]));
                }

                input = Console.ReadLine();
            }

            string invalidId = Console.ReadLine();

            List<IUnit> invalidUnits = units.Where(u => u.Id.EndsWith(invalidId)).ToList();

            invalidUnits.ForEach(u => Console.WriteLine(u.Id));
        }
    }
}
