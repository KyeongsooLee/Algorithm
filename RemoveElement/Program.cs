using System;
using static RemoveElement.RemoveElement;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 }; // Input array
            int val = 2; // Value to remove

            Console.Write("Elements in array before removal: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }

            Solution solution = new Solution();
            int k = solution.Remove_Element(nums, val);

            Console.WriteLine($"\nTotal elements after Remove Element: {k}");

            Console.Write("Elements in array after removal: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }
    }
}