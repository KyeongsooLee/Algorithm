using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesfromSortedArray
{
    internal class RemoveDuplicatesfromSortedArray
    {
        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                int k = 1;
                int previous = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] != previous)
                    {
                        nums[k] = nums[i];
                        k++;
                    }
                    previous = nums[i];
                }
                return k;
            }
        }
    }
}