using CollectionHierrarchy.Interfaces;
using System.Collections.Generic;

namespace CollectionHierrarchy.Collections
{
    public abstract class Collection : IAddable
    {
        private const int MaxCapacity = 100;

        private List<string> collection;

        protected Collection()
        {
            this.collection = new List<string>(MaxCapacity);
        }

        public List<string> Elements
        {
            get { return this.collection; }
        }

        public abstract int Add(string str);
    }
}

