using System;

namespace GenericScale
{
    public class Program
    {
        public static void Main()
        {
            int leftNumber = int.Parse(Console.ReadLine());
            int righNumber = int.Parse(Console.ReadLine());

            Scale<int> scale = new Scale<int>(leftNumber, righNumber);
            Console.WriteLine(scale.GetHavier());
        }
    }
}