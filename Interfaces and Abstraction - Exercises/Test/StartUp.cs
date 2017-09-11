using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        List<ISoldier> army = new List<ISoldier>();
        while (input != "End")
        {
            try
            {
                army.Add(SoldierFactory.CreateSoldier(input));
            }
            catch (Exception)
            {

            }
            input = Console.ReadLine();
        }

        foreach (var soldier in army)
        {
            Console.WriteLine(soldier);
        }
    }
}
