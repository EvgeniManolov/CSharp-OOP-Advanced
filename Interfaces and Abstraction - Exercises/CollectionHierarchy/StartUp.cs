using System;
using CollectionHierrarchy.Collections;

namespace CollectionHierrarchy
{
    public class StartUp
    {
        public static void Main()
        {
            string[] elementsForAdd = Console.ReadLine().Split();
            int countOfRemoveOps = int.Parse(Console.ReadLine());

            AddRemoveCollection addRemove = new AddRemoveCollection();
            AddCollection addCollection = new AddCollection();
            MyList myList = new MyList();


            foreach (string elementForAdd in elementsForAdd)
            {
                int index = addCollection.Add(elementForAdd);
                Console.Write(index + " ");
                myList.Add(elementForAdd);
            }

            Console.WriteLine();

            foreach (string elementForAdd in elementsForAdd)
            {
                int index = addRemove.Add(elementForAdd);
                Console.Write(index + " ");
            }

            Console.WriteLine();

            foreach (string elementForAdd in elementsForAdd)
            {
                int index = myList.Add(elementForAdd);
                Console.Write(index + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < countOfRemoveOps; i++)
            {
                string element = addRemove.Remove();
                Console.Write(element + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < countOfRemoveOps; i++)
            {
                string element = myList.Remove();
                Console.Write(element + " ");
            }
        }
    }
}