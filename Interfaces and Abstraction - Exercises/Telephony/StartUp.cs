using System;
using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        public static void Main()
        {
            Smartphone smartphone = new Smartphone();
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            foreach (string number in phoneNumbers)
            {
                Console.WriteLine(smartphone.Call(number));
            }

            foreach (string url in urls)
            {
                Console.WriteLine(smartphone.Browse(url));
            }
        }
    }
}

