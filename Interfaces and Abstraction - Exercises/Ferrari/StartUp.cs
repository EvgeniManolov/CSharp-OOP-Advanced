using System;
using Ferrari.Models;
using Ferrari.Interfaces;

namespace Ferrari
{
    public class StartUp
    {
        public static void Main()
        {
            string driver = Console.ReadLine();
            ICar f = new Ferrarii(driver);
            Console.WriteLine(f);

            string ferrariName = typeof(Ferrarii).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }
}
