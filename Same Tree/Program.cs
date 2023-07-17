using System;
using static Same_Tree.Same_Tree;

namespace Same_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first binary tree
            Solution.TreeNode p = new Solution.TreeNode(1);
            p.left = new Solution.TreeNode(2);
            p.right = new Solution.TreeNode(3);

            // Create the second binary tree
            Solution.TreeNode q = new Solution.TreeNode(1);
            q.left = new Solution.TreeNode(2);
            q.right = new Solution.TreeNode(3);

            Solution solution = new Solution();
            bool isSame = solution.IsSameTree(p, q);

            Console.WriteLine("Is Same Tree: " + isSame);
        }
    }
}
