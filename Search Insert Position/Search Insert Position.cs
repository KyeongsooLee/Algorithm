using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Insert_Position
{
    internal class Search_Insert_Position
    {
        public class Solution
        {
            public int SearchInsert(int[] nums, int target)
            {
                int left = 0;
                int right = nums.Length - 1;

                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (nums[mid] == target)
                    {
                        return mid;
                    }
                    else if (nums[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                return left;
            }
        }
    }
}
