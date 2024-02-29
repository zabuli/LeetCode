/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return GetNode(nums, 0, nums.Length - 1);
    }

    private TreeNode GetNode(int[] nums, int left, int right)
    {
        if (left > right)
        {
            return null;
        }
        
        var mid = left + ((right - left) / 2);
        return new TreeNode(nums[mid], 
            GetNode(nums, left, mid - 1),
            GetNode(nums, mid + 1, right));
    }
}