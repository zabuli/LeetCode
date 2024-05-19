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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var sum = GetSum(l1, l2, 0);
        var rest = GetRest(sum);

        sum = GetRecomputedSum(sum);

        var result = new ListNode(sum);
        var head = new ListNode(0);

        l1 = l1.next;
        l2 = l2.next;

        if (l1 == null && l2 == null && rest > 0)
        {
            result.next = new ListNode(rest);
        }

        while (l1 != null || l2 != null)
        {
            sum = GetSum(l1, l2, rest);
            rest = GetRest(sum);
            sum = GetRecomputedSum(sum);

            if (result.next == null)
            {
                head.val = sum;
                result.next = head;
            }
            else
            {
                head.next = new ListNode(sum);
                head = head.next;
            }

            if (l1 != null)
            {
                l1 = l1.next;
            }
            
            if (l2 != null)
            {
                l2 = l2.next;
            }

            if (l1 == null && l2 == null && rest > 0)
            {
                head.next = new ListNode(rest);
                head = head.next;
            }
        }

        return result;
    }

    private static int GetRecomputedSum(int sum)
    {
        return sum > 9 ? sum - 10 : sum;
    }

    private static int GetRest(int sum)
    {
        return sum > 9 ? sum / 10 : 0;
    }

    private static int GetSum(ListNode l1, ListNode l2, int rest)
    {
        if (l1 != null)
        {
            if (l2 != null)
            {
                return l1.val + l2.val + rest;
            }

            return l1.val + rest;
        }

        if (l2 != null)
        {
            return l2.val + rest;
        }

        return 0;
    }
}