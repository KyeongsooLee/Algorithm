using System;
using static Path_Sum.Path_Sum;
using static Path_Sum.Path_Sum.Solution;

namespace Path_Sum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create the binary tree as described in the examples.
            TreeNode root = new TreeNode(5,
                new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2))),
                new TreeNode(8, new TreeNode(13), new TreeNode(4, null, new TreeNode(1)))
            );

            int targetSum = 22;

            Solution solution = new Solution();
            bool hasPathSum = solution.HasPathSum(root, targetSum);

            Console.WriteLine("Has root-to-leaf path with sum " + targetSum + ": " + hasPathSum);
        }
    }
}
