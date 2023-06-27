using System;

namespace task2
{
    public class DotsMaker : IDotsMaker
    {
        
        decimal one_dot_procent;
        decimal one_word_procent;
        int min_dots;

        public DotsMaker(int max_word_count, int max_dots_count, int min_dots_count)
        {

            one_word_procent = 1 / (decimal)max_word_count;
            one_dot_procent = min_dots_count / (decimal)max_dots_count;
            min_dots = min_dots_count;
        }

        public string MakeDots(int current_word_count)
        {

            int dots_count = (int)Math.Round(current_word_count * one_word_procent / one_dot_procent,0,MidpointRounding.AwayFromZero);
            if (dots_count == 0)
            {
                dots_count = min_dots;   
            }
            string dots = new String('.', dots_count);
            return string.Concat(dots);

        }

        
    }
}
