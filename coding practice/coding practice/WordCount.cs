using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    class WordCount
    {
        public Dictionary<string, int> WordCount(string sentance)
        {
            sentance = sentance.ToLower();
            string[] words = sentance.Split(' ');
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(words[i]))
                {
                    dict[words[i]]++;
                }
                else
                {
                    dict.Add(words[i], 1);
                }
            }
            return dict;
        }
    }

}
