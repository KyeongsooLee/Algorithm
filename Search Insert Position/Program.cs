using System;

namespace Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Search_Insert_Position.Solution solution = new Search_Insert_Position.Solution();

            int[] nums = { 1, 3, 5, 6 }; // Input array
            int target = 5;
            Console.Write($"Input array: ");
            for (int i = 0; i < nums.Length; i++)
            {
                if ( i == nums.Length - 1)
                    Console.Write($"{nums[i]}");
                else
                    Console.Write($"{nums[i]}, ");
            }
            Console.WriteLine($"\nTarget: {target}");
            int result = solution.SearchInsert(nums, target);

            Console.WriteLine($"Result: {result}");
        }
    }
}