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

        var depth = GetDepth(head);
        var position = depth - n;

        if (position == 0)
        {
            head = head.next;
            return head;
        }

        return GetListWithoutNth(head, position);
    }

    private static int GetDepth(ListNode node)
    {
        var depth = 0;

        while(node != null)
        {
            depth++;
            node = node.next;
        }

        return depth;
    }

    private static ListNode GetListWithoutNth(ListNode head, int position)
    {
        var node = head;

        while (position > 0)
        {
            if (position == 1)
            {
                node.next = node.next.next;
            }
            else
            {
                node = node.next;
            }
           
            position--;
        }

        return head;
    }
}