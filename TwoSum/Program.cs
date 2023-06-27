using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSum twoSum = new TwoSum();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = twoSum.CalculateTwoSum(nums, target);

            Console.WriteLine($"Index: {result[0]}, {result[1]}");
        }
    }
}