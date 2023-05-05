using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupAnagramsBase anagrams = new GroupAnagramsBase();
            string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> result = anagrams.GroupAnagramsTogethoer(words);

        }
    }
}
