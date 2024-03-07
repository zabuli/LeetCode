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
 //1,3,5,n
 //1,2,3,4
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        if (head == null || head.next == null)
        {
            return head;
        }
        
        var slow = head;
        var fast = head;

        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}