using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private const int initialCapacity = 10;
        private T[] elements;

        public Stack()
        {
            this.elements = new T[initialCapacity];
        }

        public int Count { get; private set; }

        public int Capacity
        {
            get { return this.elements.Length; }
        }
        public void Push(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.Resize();
            }
            this.elements[this.Count] = element;
            this.Count++;
        }

        public void Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            this.Count--;
        }

        private void Resize()
        {
            //this.elements = this.elements.Concat(new T[this.Count]).ToArray();

            Array.Resize(ref this.elements, 2 * this.Count);

            //T[] newElements = new T[2 * this.Count];
            //Array.Copy(this.elements, newElements, this.Count);
            //this.elements = newElements;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
