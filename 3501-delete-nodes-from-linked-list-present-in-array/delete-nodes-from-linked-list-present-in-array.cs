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
    public ListNode ModifiedList(int[] nums, ListNode head) {
        var set = GetHashSet(nums);
        head = GetHead(set, head);
        var node = head;

        while (head != null)
        {
            if (head.next != null && set.Contains(head.next.val))
            {
                while (head.next != null && set.Contains(head.next.val))
                {
                    head.next = head.next.next;
                }
            }
            else
            {
                head = head.next;
            }
        }

        return node;
    }

    private static HashSet<int> GetHashSet(int[] nums)
    {
        var set = new HashSet<int>();

        foreach (var num in nums)
        {
            set.Add(num);
        }

        return set;
    }

    private ListNode GetHead(HashSet<int> nums, ListNode head)
    {
        while (head != null && nums.Contains(head.val))
        {
            head = head.next;
        }

        return head;
    }
}