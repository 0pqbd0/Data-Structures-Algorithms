/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
// public class Solution {
//     public ListNode MiddleNode(ListNode head) {
//         int counter = 0;
//         var current = head;

//         while (current != null)
//         {
//             counter++;
//             current = current.next;
//         }

//         counter = (counter / 2);
//         current = head;

//         for (int i = 0; i < counter; ++i)
//         {
//             current = current.next;
//         }
//         return current;
//     }
// }

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}