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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if (root == null)
        {
            return false;
        }
        if (root.left == null)
        {
            return GetPathSum(root.right, root.val, targetSum);
        }
        if (root.right == null)
        {
            return GetPathSum(root.left, root.val, targetSum);
        }

        return GetPathSum(root.left, root.val, targetSum)
            || GetPathSum(root.right, root.val, targetSum);
    }

    private static bool GetPathSum(TreeNode root, int sum, int targetSum) 
    {
        if (root == null)
        {
            return sum == targetSum;
        }
        if (root.left == null)
        {
            return GetPathSum(root.right, root.val + sum, targetSum);
        }
        if (root.right == null)
        {
            return GetPathSum(root.left, root.val + sum, targetSum);
        }

        return GetPathSum(root.left, root.val + sum, targetSum)
            || GetPathSum(root.right, root.val + sum, targetSum);
    }
}