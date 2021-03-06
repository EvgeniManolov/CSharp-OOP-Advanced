﻿using CollectionHierrarchy.Interfaces;

namespace CollectionHierrarchy.Collections
{
    public class AddRemoveCollection : Collection, IRemovable
    {
        public override int Add(string str)
        {
            base.Elements.Insert(0, str);
            return 0;
        }

        public string Remove()
        {
            string forReturn = base.Elements[base.Elements.Count - 1];
            base.Elements.RemoveAt(base.Elements.Count - 1);
            return forReturn;
        }
    }
}

