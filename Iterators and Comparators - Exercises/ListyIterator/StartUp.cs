using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        public static void Main()
        {
            ListyIterator<string> iterator = new ListyIterator<string>();

            string[] createLine = Console.ReadLine().Split();
            if (createLine.Count() > 1)
            {
                iterator = new ListyIterator<string>(createLine.Skip(1).ToArray());
            }

            string commandLine;
            while ((commandLine = Console.ReadLine()) != "END")
            {
                switch (commandLine)
                {
                    case "Move": Console.WriteLine(iterator.Move()); break;
                    case "HasNext": Console.WriteLine(iterator.HasNext()); break;
                    case "Print": iterator.Print(); break;
                    case "PrintAll":
                        foreach (string data in iterator)
                        {
                            Console.Write(data + " ");
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}

