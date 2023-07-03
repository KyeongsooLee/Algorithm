using System;

namespace RemoveDuplicatesfromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2, 2, 3, 4, 4, 4, 5 };
            Console.WriteLine("Original Array:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            RemoveDuplicatesfromSortedArray.Solution solution = new RemoveDuplicatesfromSortedArray.Solution();
            int newLength = solution.RemoveDuplicates(nums);

            Console.WriteLine("\nNew Array Length: " + newLength);
            Console.WriteLine("Modified Array:");
            for (int i = 0; i < newLength; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}