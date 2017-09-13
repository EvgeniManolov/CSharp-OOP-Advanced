using System;
using System.Collections;
using System.Collections.Generic;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        public List<T> collection;
        public int currIndex = 0;

        public ListyIterator(params T[] collection)
        {
            this.collection = new List<T>(collection);
        }


        public bool Move()
        {
            if (this.collection.Count - 1 > currIndex)
            {
                currIndex++;
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (this.collection.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.collection[currIndex]);
            }
        }

        public bool HasNext()
        {
            if (this.collection.Count > currIndex + 1)
            {
                return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyOwnIterator(this.collection);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class MyOwnIterator : IEnumerator<T>
        {
            private readonly List<T> collection;
            private int currentIndex;

            public MyOwnIterator(IEnumerable<T> collection)
            {
                this.Reset();
                this.collection = new List<T>(collection);
            }
            public T Current
            {
                get { return this.collection[currentIndex]; }
            }

            object IEnumerator.Current
            {
                get { return this.Current; }
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                return ++this.currentIndex < this.collection.Count;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }
        }
    }
}
