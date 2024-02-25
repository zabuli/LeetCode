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
    public bool IsBalanced(TreeNode root) { 
        if (root == null)
        {
            return true;
        }

        var left = GetDepth(root.left, 0);//0
        var right = GetDepth(root.right, 0);//2
        return Math.Abs(left - right) <= 1
            && IsBalanced(root.left) && IsBalanced(root.right);
    }

    private static int GetDepth(TreeNode root, int deep)
    {
        if (root == null)
        {
            return deep;
        }

        deep++;

        return Math.Max(GetDepth(root.left, deep), GetDepth(root.right, deep));
    }
}