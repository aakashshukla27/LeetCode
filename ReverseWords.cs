using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ReverseWords
    {
        public string ReverseWordsSolution(string s)
        {
            string[] p = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string ans = "";
            for (int i = p.Length - 1; i >= 0; i--)
            {
                ans += p[i] + " ";
            }
            return (ans.Substring(0,ans.Length - 1));
        }
    }
}
