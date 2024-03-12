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
    public ListNode RemoveZeroSumSublists(ListNode head) {
        var dict = new Dictionary<int, ListNode>();
        var sum = 0;
        var node = new ListNode(0, head);
        var current = node;

        while (current != null)
        {
            sum += current.val;

            if (!dict.ContainsKey(sum))
            {
                dict.Add(sum, current);
            }
            else
            {
                dict[sum] = current;
            }

            current = current.next;
        }

        current = node; 
        sum = 0; 

        while (current != null)
        {
            sum += current.val; 
            current.next = dict[sum].next;       
            current = current.next; 
        }

        return node.next; 
    }
}