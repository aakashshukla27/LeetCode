using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class IsValid
    {
        public bool IsValidSolution(string s)
        {
            Stack<char> comp = new Stack<char>();
            foreach(char item in s)
            {
                if(item == '(' || item == '{' || item == '[')
                {
                    comp.Push(item);
                }
                else if(item == ')')
                {
                    if (!comp.Any())
                    {
                        return false;
                    }
                    else if (comp.Peek() == '(')
                    {
                        comp.Pop();
                    }
                    else return false;
                }

                else if (item == '}')
                {
                    if (!comp.Any())
                    {
                        return false;
                    }
                    else if (comp.Peek() == '{')
                    {
                        comp.Pop();
                    }
                    else return false;
                }
                else if (item == ']')
                {
                    if (!comp.Any())
                    {
                        return false;
                    }
                    else if (comp.Peek() == '[')
                    {
                        comp.Pop();
                    }
                    else return false;
                }
            }

            return !comp.Any();
        }
    }
}
