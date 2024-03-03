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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head.next == null && n == 1)
        {
            return null;
        }

        var next = head;
        var depth = 0;
        while(next != null)
        {
            depth++;
            next = next.next;
        }

        var position = depth - n;
        if (position == 0)
        {
            head = head.next;
            return head;
        }

        next = head;

        while (position > 0)
        {
            if (position == 1)
            {
                next.next = next.next.next;
            }
            else
            {
                 next = next.next;
            }
           
            position--;
        }

        return head;
    }
}