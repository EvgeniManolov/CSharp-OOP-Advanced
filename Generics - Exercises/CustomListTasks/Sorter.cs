using System;
using System.Linq;

namespace CustomListTasks
{
    public class Sorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> customList)
            where T : IComparable<T>
        {
            IOrderedEnumerable<T> temp = customList.Elements.OrderBy(x => x);
            return new CustomList<T>(temp);
        }
    }
}
