using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    internal class RomanToInteger
    {
        public class Solution
        {
            public int RomanToInt(string s)
            {
                var map = new Dictionary<Char, int>()
                {{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}};
                s = s.Replace("IV", "IIII") // 4
                .Replace("IX", "VIIII") // 9
                .Replace("XL", "XXXX") // 40
                .Replace("XC", "LXXXX") // 90
                .Replace("CD", "CCCC") // 400
                .Replace("CM", "DCCCC"); // 900

                int sum = 0;
                foreach (var c in s)
                    sum = sum + map[c];
                return sum;
            }
        }
    }
}