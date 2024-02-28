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
    public int FindBottomLeftValue(TreeNode root) {
        var result = 0;
        return GetLeftDeepMostValue(root, ref result);
    }

    private int GetLeftDeepMostValue(TreeNode root, ref int depth)
    {
        if (root == null)
        {
            return 0;
        }

        if (root.left == null && root.right == null)
        {
            return root.val;
        }
        
        depth++;

        var leftDepth = depth; var rightDepth = depth;
        var leftValue = GetLeftDeepMostValue(root.left, ref leftDepth);
        var rightValue = GetLeftDeepMostValue(root.right, ref rightDepth);

        if (root.left != null && leftDepth >= rightDepth)
        {
            depth = leftDepth;
            return leftValue;
        }

        depth = rightDepth;
        return rightValue;
    }
}