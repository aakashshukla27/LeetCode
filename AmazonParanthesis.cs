using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class AmazonParanthesis
    {
        public AmazonParanthesis()
        {
           
        }

        public int Solve(string s)
        {
            if(s.Length < 2 || s == null)
            {
                return -1;
            }
            Stack<char> stack = new Stack<char>();
            int count = 0;
            foreach(char c in s.ToCharArray())
            {
                if(c == '(')
                {
                    stack.Push(')');
                }
                else
                {
                    if(stack.Pop() == c)
                    {
                        count++;
                    }
                    else
                    {
                        count = -1;
                    }
                }
            }
            return !stack.Any() ? count : -1;
        }
    }
}
