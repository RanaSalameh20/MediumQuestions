using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAnagrams
{
    public class GroupAnagramsBase
    {
        public IList<IList<string>> GroupAnagramsTogethoer(string[] words)
        {
            var anagrams = new Dictionary<string, List<string>>();

            foreach (string word in words)
            {
                string fingerprint = new string(word.OrderBy(c => c).ToArray());
                if (!anagrams.ContainsKey(fingerprint))
                {
                    anagrams[fingerprint] = new List<string>();
                }
                anagrams[fingerprint].Add(word);
            }

            return anagrams.Values.ToList<IList<string>>();
        }
    }
}
