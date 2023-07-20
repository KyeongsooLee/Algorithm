using System;
using static Convert_Sorted_Array_to_Binary_Search_Tree.Convert_Sorted_Array_to_Binary_Search_Tree;

namespace Convert_Sorted_Array_to_Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -10, -3, 0, 5, 9 };

            Solution solution = new Solution();
            TreeNode root = solution.SortedArrayToBST(nums);

            PrintTree(root);
        }

        static void PrintTree(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.val + ", ");

            PrintTree(node.left);
            PrintTree(node.right);
        }
    }
}