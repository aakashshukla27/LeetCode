using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Class1
    {
        public int Solve(string s, string t)
        {
            if (s.Length % t.Length != 0 || this.IsDivisiable(s, t) == false)
            {
                return -1;
            }

            int[] next = this.GetNext(t);
            if (next[t.Length - 1] == 0) // no common prefix of last char in t
            {
                return t.Length;
            }
            string divisor = t.Substring(next[t.Length - 1] + 1);
            return this.IsDivisiable(t, divisor) ? divisor.Length : t.Length;
        }

        private bool IsDivisiable(string s, string t)
        {
            for (int i = 0; i < s.Length; i += t.Length)
            {
                if (s.Substring(i, t.Length) != t)
                {
                    return false;
                }
            }

            return true;
        }

        private int[] GetNext(string t)
        {
            int[] next = new int[t.Length];
            next[0] = -1;
            int i = 0, j = -1;
            while (i < t.Length - 1)
            {
                if (j == -1 || t[i] == t[j])
                {
                    i++;
                    j++;
                    next[i] = j;
                }
                else
                {
                    j = next[j];
                }
            }

            return next;
        }
    }
}
