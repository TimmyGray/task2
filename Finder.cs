using System;
using System.Diagnostics;
using System.Linq;



namespace task2
{
    public class Finder
    {
        
        public Dictionary<string,int> Uniqwords { get; private set; }
        public string longestword;

        public Finder(string[] data)
        {
            string[] sortedbylength = data.OrderBy(w => w.Length).ToArray();
            longestword = sortedbylength.Last();
            string[] words = sortedbylength.Distinct().ToArray();
            Uniqwords = new Dictionary<string, int>(words.Length);

            for (int i = words.Length-1; i >= 0; i--)
            {
                var sameword = from w in sortedbylength
                               where w == words[i]
                               select w;
                int word_count = sameword.Count();
                Uniqwords.Add(words[i],word_count );
                Array.Resize(ref data, data.Length-word_count);
                
            }

            var sorted_words = from entry in Uniqwords
                               orderby entry.Value
                               ascending
                               select entry;

            Uniqwords = sorted_words.ToDictionary(x => x.Key, y => y.Value);

        }


    }
}
