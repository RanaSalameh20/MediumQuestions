using System.Collections.Generic;
using System.Linq;

namespace ContainsDuplicate
{
    internal class Duplicates
    {
        public bool CheckForDuplicates(int[] numbers)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int number in numbers)
            {
                if (set.Contains(number))
                {
                    return true;
                }
                set.Add(number);
            }
            return false;
        }
        public bool CheckForDuplicatesUsingLINQ(int[] numbers)
        {
            var numberOFGroups = numbers.GroupBy(number => number).Count();

            return numberOFGroups != numbers.Length;
        }
    }
}