using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfStringAndInteger
{
    public class Program
    {
        public static void Main()
        {

            //Solution: Generic Box of Integer and Strings (1st and 2nd tasks)
            //int numberOfLines = int.Parse(Console.ReadLine());
            //
            //for (int i = 0; i < numberOfLines; i++)
            //{
            //    BoxOfStrings - 1st task
            //    Box<string> boxOfStr = new Box<string>(Console.ReadLine());
            //    Console.WriteLine(boxOfStr);
            //
            //    BoxOfintegers - 2nd task
            //    Box<int> boxOfInt = new Box<int>(int.Parse(Console.ReadLine()));
            //    Console.WriteLine(boxOfInt);
            //}

            //Solution : Generic Swap Method Strings and Integers (3rd and 4th tasks)
            //
            //int numberOfLines = int.Parse(Console.ReadLine());
            //List<Box<int>> listOfBoxes = new List<Box<int>>();
            //
            //for (int i = 0; i < numberOfLines; i++)
            //{
            //    Box<int> boxOfInt = new Box<int>(int.Parse(Console.ReadLine()));
            //    listOfBoxes.Add(boxOfInt);
            //}
            //
            //string[] indexes = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();
            //
            //SwapElements(listOfBoxes, indexes[0], indexes[1]);
            //
            //foreach (var box in listOfBoxes)
            //{
            //    Console.WriteLine(box);
            //}

            //Solution : Generic Count Method Strings and Integers (5th and 6th tasks)

            int numberOfLines = int.Parse(Console.ReadLine());
            List<Box<string>> listOfBoxes = new List<Box<string>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                Box<string> boxOfStr = new Box<string>(Console.ReadLine());
                listOfBoxes.Add(boxOfStr);
            }

            string element = Console.ReadLine();
            var result = GetGreaterElementsCount(listOfBoxes, element);
            Console.WriteLine(result);


        }

        private static int GetGreaterElementsCount<T>(List<Box<T>> listOfBoxes, T element)
            where T : IComparable<T>
        {
            return listOfBoxes.Count(b => b.Value.CompareTo(element) > 0);
        }


        // private static void SwapElements<T>(List<Box<T>> listOfBoxes, int firstIndex, int secondIndex)
        // {
        //     string tempBox = listOfBoxes[firstIndex];
        //     listOfBoxes[firstIndex] = listOfBoxes[secondIndex];
        //     listOfBoxes[secondIndex] = tempBox;
        // }
    }
}
