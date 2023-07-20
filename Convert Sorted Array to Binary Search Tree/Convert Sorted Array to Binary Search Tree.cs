using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Sorted_Array_to_Binary_Search_Tree
{
    internal class Convert_Sorted_Array_to_Binary_Search_Tree
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
            public TreeNode SortedArrayToBST(int[] nums)
            {
                return ConstructBST(nums, 0, nums.Length - 1);
            }

            private TreeNode ConstructBST(int[] nums, int left, int right)
            {
                if (left > right)
                {
                    return null;
                }

                int mid = left + (right - left) / 2;
                TreeNode root = new TreeNode(nums[mid]);

                root.left = ConstructBST(nums, left, mid - 1);
                root.right = ConstructBST(nums, mid + 1, right);

                return root;
            }
        }
    }
}
