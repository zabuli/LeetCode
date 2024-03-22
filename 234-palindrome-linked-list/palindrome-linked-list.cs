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
    public bool IsPalindrome(ListNode head) {
        if (head == null || head.next == null)
        {
            return true;
        }

        var slow = head;
        var fast = head.next;
        var stack = new Stack<ListNode>();
        stack.Push(slow);

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            stack.Push(slow);

            fast = fast.next.next;
        }

        if (fast == null)
        {
            stack.Pop();
        }
        if (stack.Count == 0)
        {
            return false;
        }

        while (slow != null && stack.Count > 0)
        {
            slow = slow.next;
            
            if (stack.Pop().val != slow.val)
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}