using System;

namespace Maximum_Depth_of_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the binary tree for Example 1: [3,9,20,null,null,15,7]
            Maximum_Depth_of_Binary_Tree.TreeNode node15 = new Maximum_Depth_of_Binary_Tree.TreeNode(15);
            Maximum_Depth_of_Binary_Tree.TreeNode node7 = new Maximum_Depth_of_Binary_Tree.TreeNode(7);
            Maximum_Depth_of_Binary_Tree.TreeNode node20 = new Maximum_Depth_of_Binary_Tree.TreeNode(20, node15, node7);
            Maximum_Depth_of_Binary_Tree.TreeNode node9 = new Maximum_Depth_of_Binary_Tree.TreeNode(9);
            Maximum_Depth_of_Binary_Tree.TreeNode node3 = new Maximum_Depth_of_Binary_Tree.TreeNode(3, node9, node20);

            // Create an instance of the Solution class
            Maximum_Depth_of_Binary_Tree.Solution solution = new Maximum_Depth_of_Binary_Tree.Solution();

            // Call the MaxDepth method and print the result
            int maxDepth = solution.MaxDepth(node3);
            Console.WriteLine("Maximum Depth of Binary Tree: " + maxDepth);
        }
    }
}