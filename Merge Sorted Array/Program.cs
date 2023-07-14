using System;
using static Merge_Sorted_Array.Merge_Sorted_Array;

namespace Merge_Sorted_Array
{
    class Program
    {
        static void Main()
        {
            Solution solution = new Solution();

            // Example 1
            int[] nums1_1 = { 1, 2, 3, 0, 0, 0 };
            int m_1 = 3;
            int[] nums2_1 = { 2, 5, 6 };
            int n_1 = 3;
            PrintArrays(nums1_1, nums2_1);
            solution.Merge(nums1_1, m_1, nums2_1, n_1);
            Console.WriteLine("Example 1:");
            PrintArray(nums1_1);

            // Example 2
            int[] nums1_2 = { 1 };
            int m_2 = 1;
            int[] nums2_2 = { };
            int n_2 = 0;
            PrintArrays(nums1_2, nums2_2);
            solution.Merge(nums1_2, m_2, nums2_2, n_2);
            Console.WriteLine("Example 2:");
            PrintArray(nums1_2);

            // Example 3
            int[] nums1_3 = { 0 };
            int m_3 = 0;
            int[] nums2_3 = { 1 };
            int n_3 = 1;
            PrintArrays(nums1_3, nums2_3);
            solution.Merge(nums1_3, m_3, nums2_3, n_3);
            Console.WriteLine("Example 3:");
            PrintArray(nums1_3);

            // Custom Example
            int[] nums1_4 = { 4, 5, 6, 0, 0, 0 };
            int m_4 = 3;
            int[] nums2_4 = { 1, 2, 3 };
            int n_4 = 3;
            PrintArrays(nums1_4, nums2_4);
            solution.Merge(nums1_4, m_4, nums2_4, n_4);
            Console.WriteLine("Custom Example:");
            PrintArray(nums1_4);
        }

        static void PrintArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }

        static void PrintArrays(int[] nums1, int[] nums2)
        {
            Console.WriteLine("nums1: " + string.Join(", ", nums1));
            Console.WriteLine("nums2: " + string.Join(", ", nums2));
        }
    }
}