using BirthdayCelebrations.Interfaces;
using BirthdayCelebrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
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

                if (tokens[0] != "Robot")
                {
                    if (tokens.Length == 5)
                    {
                        units.Add(new Citizen(tokens[1], tokens[4]));
                    }
                    else
                    {
                        units.Add(new Pet(tokens[1], tokens[2]));
                    }
                }

                input = Console.ReadLine();
            }

            string year = Console.ReadLine();

            List<IUnit> birtdays = units.Where(u => u.Birthdate.EndsWith(year)).ToList();

            birtdays.ForEach(u => Console.WriteLine(u.Birthdate));
        }
    }
}
