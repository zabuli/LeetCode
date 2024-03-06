/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        var set = new HashSet<ListNode>();
        while (head != null)
        {
            if (set.Contains(head))
            {
                return true;
            }
            set.Add(head);
            head = head.next;
        }

        return false;
    }
}