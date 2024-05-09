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
    public ListNode RemoveElements(ListNode head, int val) {
        if (head == null)
        {
            return null;
        }

        if (head.val == val)
        {
            while (head != null && head.val == val)
            {
                head = head.next;
            }
        }

        if (head != null)
        {
            head.next = RemoveElements(head.next, val);
        }
        
        return head;
    }
}