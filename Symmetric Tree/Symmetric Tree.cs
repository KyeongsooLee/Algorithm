using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symmetric_Tree
{
    internal class Symmetric_Tree
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
 
        public class Solution
        {
            public bool IsSymmetric(TreeNode root)
            {
                if (root == null)
                    return true;

                return IsMirror(root.left, root.right);
            }
            private bool IsMirror(TreeNode node1, TreeNode node2)
            {
                if (node1 == null && node2 == null)
                    return true;

                if (node1 == null || node2 == null)
                    return false;

                return (node1.val == node2.val)
                    && IsMirror(node1.left, node2.right)
                    && IsMirror(node1.right, node2.left);
            }
        }
    }
}
