using System;
using System.Collections.Generic;
using System.Linq;
using FoodShortage.Interfaces;
using FoodShortage.Models;

namespace FoodShortage
{
    public class Program
    {
        public static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            List<IUnit> units = new List<IUnit>();

            for (int i = 0; i < people; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                if (tokens.Length == 4)
                {
                    units.Add(new Citizen(tokens[0]));
                }
                else
                {
                    units.Add(new Rebel(tokens[0]));
                }
            }

            string name = Console.ReadLine();
            while (name != "End")
            {
                IUnit found = units.FirstOrDefault(u => u.Name == name);
                found?.BuyFood();
                name = Console.ReadLine();
            }

            int totalFood = units.Sum(unit => unit.Food);
            Console.WriteLine(totalFood);
        }
    }
}

