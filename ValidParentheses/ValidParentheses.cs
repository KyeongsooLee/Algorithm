using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    internal class ValidParentheses
    {
        public class Solution
        {
            public bool IsValid(string s)
            {

                Dictionary<char, char> Parentheses = new Dictionary<char, char>() {
                    { '(', ')' },
                    { '[', ']' },
                    { '{', '}' }
                };

                if (s.Length % 2 != 0 || s.Length == 0)
                    return false;

                Stack<char> stack = new Stack<char>();

                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    if (Parentheses.ContainsKey(c))
                        stack.Push(c);
                    else if ((stack.Count() == 0 || Parentheses[stack.Pop()] != c))
                        return false;
                }
                return stack.Count() == 0;
            }
        }
    }
}
