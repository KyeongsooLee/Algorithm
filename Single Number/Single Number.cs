using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Number
{
    internal class Single_Number
    {
        public class Solution
        {
            public int SingleNumber(int[] nums)
            {
                int result = 0;

                foreach (int num in nums)
                {
                    result ^= num; // XOR
                }

                return result;
            }
        }
    }
}
