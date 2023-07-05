using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElement
{
    internal class RemoveElement
    {
        public class Solution
        {
            public int Remove_Element(int[] nums, int val)
            {
                int k = 0;
                foreach (int i in nums)
                    if (i != val)
                        nums[k++] = i;
                return k;
            }
        }
    }
}
