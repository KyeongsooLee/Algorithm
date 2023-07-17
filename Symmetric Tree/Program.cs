using System;

namespace Symmetric_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first symmetric binary tree
            Symmetric_Tree.TreeNode root1 = new Symmetric_Tree.TreeNode(1);
            root1.left = new Symmetric_Tree.TreeNode(2);
            root1.right = new Symmetric_Tree.TreeNode(2);
            root1.left.left = new Symmetric_Tree.TreeNode(3);
            root1.left.right = new Symmetric_Tree.TreeNode(4);
            root1.right.left = new Symmetric_Tree.TreeNode(4);
            root1.right.right = new Symmetric_Tree.TreeNode(3);

            // Create the second asymmetric binary tree
            Symmetric_Tree.TreeNode root2 = new Symmetric_Tree.TreeNode(1);
            root2.left = new Symmetric_Tree.TreeNode(2);
            root2.right = new Symmetric_Tree.TreeNode(2);
            root2.left.right = new Symmetric_Tree.TreeNode(3);
            root2.right.right = new Symmetric_Tree.TreeNode(3);

            Symmetric_Tree.Solution solution = new Symmetric_Tree.Solution();

            bool isSymmetric1 = solution.IsSymmetric(root1);
            Console.WriteLine("Is Symmetric (Tree 1): " + isSymmetric1);

            bool isSymmetric2 = solution.IsSymmetric(root2);
            Console.WriteLine("Is Symmetric (Tree 2): " + isSymmetric2);
        }
    }
}