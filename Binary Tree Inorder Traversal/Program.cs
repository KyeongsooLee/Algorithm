using System;
using System.Collections.Generic;
using static Binary_Tree_Inorder_Traversal.Binary_Tree_Inorder_Traversal;

namespace Binary_Tree_Inorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a binary tree
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            Solution solution = new Solution();
            IList<int> inorderTraversal = solution.InorderTraversal(root);

            Console.WriteLine("Inorder Traversal: " + string.Join(", ", inorderTraversal));
        }
    }
}