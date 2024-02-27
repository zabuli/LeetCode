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
    public int DiameterOfBinaryTree(TreeNode root) {
        var result = 0;
        GetDepth(root, ref result);
        return result;
    }

    private static int GetDepth(TreeNode root, ref int depth)
    {
        if (root == null)
        {
            return 0;
        }

        var left = GetDepth(root.left, ref depth);
        var right = GetDepth(root.right, ref depth);

        depth = Math.Max(depth, left + right);

        return Math.Max(left, right) + 1;
    }
}