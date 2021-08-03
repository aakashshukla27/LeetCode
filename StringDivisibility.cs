using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class StringDivisibility
    {
        public StringDivisibility(string s, string t)
        {

        }

        private int solve(string s, string t)
        {
			if (s.Length % t.Length > 0)
				return -1;
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i * t.Length < s.Length; i++)
			{
				sb.Append(t);
			}
			if (!sb.ToString().Equals(s))
				return -1;
			for (int i = 1; i <= t.Length; i++)
			{
				sb = new StringBuilder();
				String subStr = t.Substring(0, i);
				while (sb.Length < t.Length)
				{
					sb.Append(subStr);
				}
				if (sb.ToString().Equals(t))
					return i;
			}
			return -1;
		}
    }
}
