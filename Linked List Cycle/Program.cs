using System;
using static Linked_List_Cycle.Linked_List_Cycle;

namespace Linked_List_Cycle
{
    class Program
    {
        static void Main()
        {
            Solution solution = new Solution();

            // Example 1: [3,2,0,-4] with pos = 1
            ListNode node4 = new ListNode(-4);
            ListNode node3 = new ListNode(0);
            ListNode node2 = new ListNode(2);
            ListNode node1 = new ListNode(3);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node2; // creates the cycle

            bool result1 = solution.HasCycle(node1);
            Console.WriteLine("Example 1: " + result1); // Output: true

            // Example 2: [1,2] with pos = 0
            ListNode node5 = new ListNode(1);
            ListNode node6 = new ListNode(2);

            node5.next = node6;
            node6.next = node5; // creates the cycle

            bool result2 = solution.HasCycle(node5);
            Console.WriteLine("Example 2: " + result2); // Output: true

            // Example 3: [1] with pos = -1
            ListNode node7 = new ListNode(1);

            bool result3 = solution.HasCycle(node7);
            Console.WriteLine("Example 3: " + result3); // Output: false
        }
    }
}