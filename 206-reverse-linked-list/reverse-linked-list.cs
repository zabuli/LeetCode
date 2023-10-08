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
    public ListNode ReverseList(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        var result = GetListNode(head, null);
        return result;
    }

    private ListNode GetListNode(ListNode head, ListNode prev)
    {
        if (head == null)
        {
            return prev;
        }

        var tmp = head.next;
        if (prev != null)
        {
            head.next = prev;
        }
        else
        {
            head.next = null;
        }

        return GetListNode(tmp, head);
    }
}