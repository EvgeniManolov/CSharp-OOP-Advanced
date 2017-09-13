using System;
using System.Linq;
using System.Collections.Generic;

namespace Froggy
{
    public class StartUp
    {
        public static void Main()
        {
            List<int> stones = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Lake myLake = new Lake(stones);
            Console.WriteLine(string.Join(", ", myLake));
        }
    }
}

