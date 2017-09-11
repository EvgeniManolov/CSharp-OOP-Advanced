using System;
using ExplicitInterfaces.Interfaces;
using ExplicitInterfaces.Models;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                string[] tokens = inputLine.Split();
                string name = tokens[0];
                string country = tokens[1];
                int age = int.Parse(tokens[2]);

                IPerson iperson = new Citizen(name, age, country);
                IResident iresident = new Citizen(name, age, country);
                Console.WriteLine(iperson.GetName());
                Console.WriteLine(iresident.GetName());

                inputLine = Console.ReadLine();
            }
        }
    }
}

