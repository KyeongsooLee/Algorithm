using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_Last_Word
{
    internal class Length_of_Last_Word
    {
        public class Solution
        {
            public int LengthOfLastWord(string s)
            {
                int count = 0;
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] == ' ' && count != 0)
                        return count;
                    if (s[i] != ' ')
                        count++;
                }
                return count;
            }
        }
    }
}
