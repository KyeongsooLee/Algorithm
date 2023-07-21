using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Binary_Tree
{
    internal class Balanced_Binary_Tree
    {
        public class Solution
        {
            public class TreeNode {
                public int val;
                public TreeNode left;
                public TreeNode right;
                public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                    this.val = val;
                    this.left = left;
                    this.right = right;
                }
            }
 
            public bool IsBalanced(TreeNode root)
            {
                return IsBalancedHelper(root) != -1;
            }
            private int IsBalancedHelper(TreeNode node)
            {
                if (node == null)
                    return 0;

                int leftHeight = IsBalancedHelper(node.left);
                if (leftHeight == -1)
                    return -1;

                int rightHeight = IsBalancedHelper(node.right);
                if (rightHeight == -1)
                    return -1;

                if (Math.Abs(leftHeight - rightHeight) > 1)
                    return -1;

                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }
    }
}
