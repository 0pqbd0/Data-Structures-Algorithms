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
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null && list2 == null)
        {
            return null;
        }
        if (list1 == null)
        {
            return list2;
        }
        if (list2 == null)
        {
            return list1;
        }

        ListNode newNode = new ListNode();
        ListNode resultNode = newNode;
        while (list1 != null || list2 != null)
        {
            if (list1 == null || list2 != null && list1.val > list2.val)
            {
                newNode.next = list2;
                list2 = list2.next;
                newNode = newNode.next;
            }

            else if (list2 == null || list1 != null && list1.val <= list2.val)
            {
                newNode.next = list1;
                list1 = list1.next;
                newNode = newNode.next;
            }
        }
        return resultNode.next;
    }
}