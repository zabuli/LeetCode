/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var lengthA = GetLinkedListLength(headA);
        var lengthB = GetLinkedListLength(headB);

        while (lengthA > lengthB)
        {
            headA = headA.next;
            lengthA--;
        }

        while (lengthB > lengthA)
        {
            headB = headB.next;
            lengthB--;
        }

        while (headA != headB)
        {
            headA = headA.next;
            headB = headB.next;
        }

        return headA;
    }

    private static int GetLinkedListLength(ListNode head)
    {
        var length = 0;

        while (head != null)
        {
            length++;
            head = head.next;
        }

        return length;
    }
}