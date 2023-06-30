using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    internal class LongestCommonPrefix
    {
        public class Solution
        {
            public string LongestCommonPref(string[] strs)
            {
                int minLength = strs.Min(e => e.Length);
                string result = strs.First(e => e.Length == minLength);

                foreach (string str in strs)
                {
                    for (int i = 0; i < minLength; i++)
                    {
                        if (str[i] != result[i])
                        {
                            minLength = i;
                            if (minLength == 0) return "";
                        }
                    }
                }

                return result.Substring(0, minLength);
            }
        }
    }
}
