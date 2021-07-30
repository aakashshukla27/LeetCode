using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LongestPalindromicSubstring
    {
        private int[] p;  // p[i] = length of longest palindromic substring of t, centered at i
        private String s;  // original string
        private char[] t;  // transformed string
        public string LongestPalindrome(string s)
        {
            this.s = s;
            preprocess(s);
            p = new int[t.Length];

            int center = 0, right = 0;
            for (int i = 1; i < t.Length - 1; i++)
            {
                int mirror = 2 * center - i;

                if (right > i)
                    p[i] = Math.Min(right - i, p[mirror]);

                // attempt to expand palindrome centered at i
                while (t[i + (1 + p[i])] == t[i - (1 + p[i])])
                    p[i]++;

                // if palindrome centered at i expands past right,
                // adjust center based on expanded palindrome.
                if (i + p[i] > right)
                {
                    center = i;
                    right = i + p[i];
                }
            }
            
            return longestPalindromicSubstring();
            
        }

        private void preprocess(string s)
        {
            t = new char[s.Length * 2 + 3];
            t[0] = '$';
            t[s.Length * 2 + 2] = '@';
            for (int i = 0; i < s.Length; i++)
            {
                t[2 * i + 1] = '#';
                t[2 * i + 2] = s[i];
            }
            t[s.Length * 2 + 1] = '#';
        }

        // longest palindromic substring
        public String longestPalindromicSubstring()
        {
            int length = 0;   // length of longest palindromic substring
            int center = 0;   // center of longest palindromic substring
            for (int i = 1; i < p.Length - 1; i++)
            {
                if (p[i] > length)
                {
                    length = p[i];
                    center = i;
                }
            }
            return s.Substring((center - 1 - length) / 2, (center - 1 + length) / 2);
        }

        public String longestPalindromicSubstring(int i)
        {
            int length = p[i + 2];
            int center = i + 2;
            return s.Substring((center - 1 - length) / 2, (center - 1 + length) / 2);
        }


    }
}
