using System;
using static Balanced_Binary_Tree.Balanced_Binary_Tree;

namespace Balanced_Binary_Tree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creating the binary tree for example 1: [3, 9, 20, null, null, 15, 7]
            Solution.TreeNode example1Root = new Solution.TreeNode(3,
                new Solution.TreeNode(9),
                new Solution.TreeNode(20,
                    new Solution.TreeNode(15),
                    new Solution.TreeNode(7)
                )
            );

            // Creating an instance of the Solution class
            Solution solution = new Solution();

            // Checking if the binary tree is height-balanced
            bool isBalanced = solution.IsBalanced(example1Root);

            // Outputting the result
            Console.WriteLine("Is the binary tree height-balanced? " + isBalanced);
        }
    }
}
