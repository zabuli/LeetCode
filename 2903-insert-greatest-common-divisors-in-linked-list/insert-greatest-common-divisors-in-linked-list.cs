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
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        var node = head;

        while (head != null && head.next != null)
        {
            var next = head.next;
            head.next = new ListNode(GCD(head.val, head.next.val), next);
            head = head.next.next;
        }

        return node;
    }

    private static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }

        return GCD(b, a %= b);
    }
}