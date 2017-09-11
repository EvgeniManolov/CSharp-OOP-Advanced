using System.Collections.Generic;
using System.Linq;

namespace BofOfT
{
    public class Box<T>
    {
        private IList<T> list;

        public Box()
        {
            this.list = new List<T>();
        }

        public void Add(T element)
        {
            this.list.Add(element);
        }

        public T Remove()
        {
            T remove = list.LastOrDefault();
            list.RemoveAt(list.Count - 1);
            return remove;
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}

