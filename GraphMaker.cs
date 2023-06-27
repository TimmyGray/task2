using System;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace task2
{
    internal class GraphMaker : IGraphMaker
    {
        private Finder finder;

        public GraphMaker(string[] data)
        {

            finder = new Finder(data);

        }


        public void DrowGraph()
        {
            DotsMaker dotsmaker = new DotsMaker(finder.Uniqwords.Values.Last(), 10, 1);
            foreach(var word in finder.Uniqwords)
            {
                string lowerscores = new('_', finder.longestword.Length - word.Key.Length);
                string dots = dotsmaker.MakeDots(word.Value);
                string normalize_word = lowerscores+word.Key;

                Console.WriteLine($"{normalize_word}: {dots}");
            }
        }
    }
}
