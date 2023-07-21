using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Depth_of_Binary_Tree
{
    internal class Minimum_Depth_of_Binary_Tree
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
        public class Solution
        {
            public int MinDepth(TreeNode root)
            {
                if (root == null)
                    return 0;

                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                int depth = 1;

                while (queue.Count > 0)
                {
                    int levelSize = queue.Count;

                    for (int i = 0; i < levelSize; i++)
                    {
                        TreeNode currentNode = queue.Dequeue();

                        // Check if it's a leaf node
                        if (currentNode.left == null && currentNode.right == null)
                        {
                            return depth;
                        }
                        if (currentNode.left != null)
                        {
                            queue.Enqueue(currentNode.left);
                        }
                        if (currentNode.right != null)
                        {
                            queue.Enqueue(currentNode.right);
                        }
                    }
                    depth++;
                }

                return depth;
            }
        }
    }
}
