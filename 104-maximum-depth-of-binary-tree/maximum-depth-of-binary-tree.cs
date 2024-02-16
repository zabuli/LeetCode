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
    public int MaxDepth(TreeNode root) {
        if (root == null)
        {
            return 0;
        } 

        return GetDepth(root, 1) - 1;
    }

    private int GetDepth(TreeNode root, int depth)
    {
        if (root == null)
        {
            return depth;
        }

        return Math.Max(GetDepth(root.left, depth + 1), GetDepth(root.right, depth + 1));
    }
}