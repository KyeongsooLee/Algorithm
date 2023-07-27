using System;
using static Majority_Element.Majority_Element;

namespace Majority_Element
{
    class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            // Test case 1
            int[] nums1 = { 3, 2, 3 };
            int result1 = solution.MajorityElement(nums1);
            Console.WriteLine("Test case 1: Majority element is " + result1);

            // Test case 2
            int[] nums2 = { 2, 2, 1, 1, 1, 2, 2 };
            int result2 = solution.MajorityElement(nums2);
            Console.WriteLine("Test case 2: Majority element is " + result2);
        }
    }
}