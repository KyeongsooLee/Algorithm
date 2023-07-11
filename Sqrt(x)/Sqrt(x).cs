using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqrt_x_
{
    internal class Sqrt_x_
    {
        public class Solution
        {
            public int MySqrt(int x)
            {
                if (x == 0)
                    return 0;

                int left = 1;
                int right = x;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (mid == x / mid)
                        return mid;
                    else if (mid < x / mid)
                        left = mid + 1;
                    else
                        right = mid - 1;
                }

                return right;
            }
        }
    }
}
