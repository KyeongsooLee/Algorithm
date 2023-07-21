using System;
using static Minimum_Depth_of_Binary_Tree.Minimum_Depth_of_Binary_Tree;

namespace Minimum_Depth_of_Binary_Tree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Example 1: [3, 9, 20, null, null, 15, 7]
            TreeNode example1Root = new TreeNode(3,
                new TreeNode(9),
                new TreeNode(20, 
                new TreeNode(15), 
                new TreeNode(7))
            );

            Solution solution = new Solution();
            int minDepthExample1 = solution.MinDepth(example1Root);
            Console.WriteLine("Minimum depth of Example 1: " + minDepthExample1); // Output: 2

            // Example 2: [2, null, 3, null, 4, null, 5, null, 6]
            TreeNode example2Root = new TreeNode(2,
                null,
                new TreeNode(3,
                null,
                new TreeNode(4,
                null,
                new TreeNode(5,
                null,
                new TreeNode(6)
                ))));

            int minDepthExample2 = solution.MinDepth(example2Root);
            Console.WriteLine("Minimum depth of Example 2: " + minDepthExample2); // Output: 5
        }
    }
}
