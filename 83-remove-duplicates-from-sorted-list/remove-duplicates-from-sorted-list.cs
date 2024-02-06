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
    public ListNode DeleteDuplicates(ListNode head) {
        return DeleteDuplicates(head, new HashSet<int>());
    }

    private ListNode? DeleteDuplicates(ListNode? head, HashSet<int> set)
    {
        if (head == null)
        {
            return null;
        }
        if (set.Contains(head.val))
        {
            head = DeleteDuplicates(head.next, set);
        }
        else
        {
            set.Add(head.val);
            head.next = DeleteDuplicates(head.next, set);
        }

        return head;
    }
}