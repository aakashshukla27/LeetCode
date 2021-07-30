using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MostCommonWord
    {
        public string MostCommonWordSolution(string paragraph, string[] banned)
        {
            //char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            char[] delimiterChars =  { '!', '?','\'',',',';','.', ' ', '\t', ':'};
            paragraph = paragraph.ToLower();
            string[] words = paragraph.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> store = new Dictionary<string, int>();

            HashSet<string> banlist = new HashSet<string>();

            foreach(string ban in banned)
            {
                if (!banlist.Contains(ban))
                {
                    banlist.Add(ban);
                }               
            }

            foreach(string word in words)
            {
                bool temp = !banlist.Contains(word);
                if (!store.ContainsKey(word) && temp)
                {
                    store.Add(word, 1);
                }
                else if(temp)
                {
                    store[word]++;
                }
            }

            return store.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;


        }
    }
}
