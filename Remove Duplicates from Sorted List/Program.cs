using System;
using static Remove_Duplicates_from_Sorted_List.Remove_Duplicates_from_Sorted_List;

namespace Remove_Duplicates_from_Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a sample linked list: 1 -> 1 -> 2 -> 3 -> 3
            ListNode head = new ListNode(1);
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(3);

            head.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            Solution solution = new Solution();
            ListNode result = solution.DeleteDuplicates(head);

            // Print the resulting linked list
            Console.WriteLine("Resulting Linked List:");
            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
        }
    }
}