using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_Sum
{
    internal class Path_Sum
    {
        public class Solution
        {
            public class TreeNode
            {
                public int val;
                public TreeNode left;
                public TreeNode right;
                public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
                {
                    this.val = val;
                    this.left = left;
                    this.right = right;
                }
            }
            public bool HasPathSum(TreeNode root, int targetSum)
            {
                if (root == null)
                {
                    return false; // Empty tree has no root-to-leaf path.
                }

                // Check if the current node is a leaf node and if its value matches the targetSum.
                if (root.left == null && root.right == null && root.val == targetSum)
                {
                    return true;
                }

                // Recursively check the left and right subtrees.
                return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
            }
        }
    }
}
