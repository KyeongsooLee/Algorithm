using System;
using static Single_Number.Single_Number;

namespace Single_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums1 = { 2, 2, 1 };
            int result1 = solution.SingleNumber(nums1);
            Console.WriteLine(result1); // Output: 1

            int[] nums2 = { 4, 1, 2, 1, 2 };
            int result2 = solution.SingleNumber(nums2);
            Console.WriteLine(result2); // Output: 4

            int[] nums3 = { 1 };
            int result3 = solution.SingleNumber(nums3);
            Console.WriteLine(result3); // Output: 1
        }
    }
}
