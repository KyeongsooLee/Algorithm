using System;

namespace MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeTwoSortedLists.ListNode list1 = new MergeTwoSortedLists.ListNode(1);
            list1.next = new MergeTwoSortedLists.ListNode(2);
            list1.next.next = new MergeTwoSortedLists.ListNode(4);

            MergeTwoSortedLists.ListNode list2 = new MergeTwoSortedLists.ListNode(1);
            list2.next = new MergeTwoSortedLists.ListNode(3);
            list2.next.next = new MergeTwoSortedLists.ListNode(4);

            MergeTwoSortedLists.Solution solution = new MergeTwoSortedLists.Solution();

            MergeTwoSortedLists.ListNode mergedList = solution.MergeTwoLists(list1, list2);

            Console.WriteLine("Merged List:");
            while (mergedList != null)
            {
                Console.Write(mergedList.val + " ");
                mergedList = mergedList.next;
            }
        }
    }
}