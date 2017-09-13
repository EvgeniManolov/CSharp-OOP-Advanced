using System.Collections.Generic;

namespace StrategyPattern.Comparators
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);
            if (result == 0)
            {
                char xNameFirstLetter = char.ToLower(x.Name[0]);
                char yNameFirstLetter = char.ToLower(y.Name[0]);
                result = xNameFirstLetter - yNameFirstLetter;
            }
            return result;
        }
    }
}
