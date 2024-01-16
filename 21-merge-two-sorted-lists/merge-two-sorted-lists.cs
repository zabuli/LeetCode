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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null)
        {
            return list2;
        }
        if (list2 == null)
        {
            return list1;
        }
        
        var list = GetListNode(new ListNode(), list1, list2);
        return list;
    }

    private ListNode GetListNode(ListNode list, ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null)
        {
            return null;
        }

        if (list1 == null)
        {
            list.val = list2.val;
            list.next = GetListNode(new ListNode(), list1, list2.next);
        }
        else if (list2 == null)
        {
            list.val = list1.val;
            list.next = GetListNode(new ListNode(), list1.next, list2);
        }
        else if (list1.val < list2.val)
        {
            list.val = list1.val;
            list.next = GetListNode(new ListNode(), list1.next, list2);
        }
        else
        {
            list.val = list2.val;
            list.next = GetListNode(new ListNode(), list1, list2.next);
        }

        return list;
    }
}