using System;

namespace Tuples
{
    class StartUp
    {
        static void Main()
        {       //Tuple
                // string infoLine = Console.ReadLine().Split();
                // string names = $"{infoLine[0]} {infoLine[1]}";
                // string address = infoLine[2];
                // Tuple<string, string> namesAndAddress = new Tuple<string, string>(names, address);
                // Console.WriteLine(namesAndAddress);
                //
                // string[] infoLine2 = Console.ReadLine().Split();
                // string name = infoLine2[0];
                // int liters = int.Parse(infoLine2[1]);
                // Tuple<string, int> nameAndLiters = new Tuple<string, int>(name, liters);
                // Console.WriteLine(nameAndLiters);
                //
                // string[] infoLine3 = Console.ReadLine().Split();
                // int someInteger = int.Parse(infoLine3[0]);
                // double someDouble = double.Parse(infoLine3[1]);
                // Tuple<string, int> intAndDouble = new Tuple<int, double>(someInteger, someDouble);
                // Console.WriteLine(intAndDouble);


            //Threeuple
            string[] infoLine = Console.ReadLine().Split();
            string names = $"{infoLine[0]} {infoLine[1]}";
            string address = infoLine[2];
            string city = infoLine[3];
            Tuple<string, string, string> namesAndAddress = new Tuple<string, string, string>(names, address, city);
            Console.WriteLine(namesAndAddress);

            string[] infoLine2 = Console.ReadLine().Split();
            string name = infoLine2[0];
            int liters = int.Parse(infoLine2[1]);
            string drunkOrNot = infoLine2[2];
            if (drunkOrNot == "drunk")
            {
                Tuple<string, int, string> nameAndLitersAndDrunkOrNot = new Tuple<string, int, string>(name, liters, "True");
                Console.WriteLine(nameAndLitersAndDrunkOrNot);
            }
            else
            {
                Tuple<string, int, string> nameAndLitersAndDrunkOrNot = new Tuple<string, int, string>(name, liters, "False");
                Console.WriteLine(nameAndLitersAndDrunkOrNot);
            }

            string[] infoLine3 = Console.ReadLine().Split();
            string someName = infoLine3[0];
            double someDouble = double.Parse(infoLine3[1]);
            string someString = infoLine3[2];
            Tuple<string, double, string> nameAndDoubleAndString = new Tuple<string, double, string>(someName, someDouble, someString);
            Console.WriteLine(nameAndDoubleAndString);
        }
    }
}
