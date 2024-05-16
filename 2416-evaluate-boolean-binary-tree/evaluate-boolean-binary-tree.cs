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
    public bool EvaluateTree(TreeNode root) {
        switch (root.val)
        {
            case 0:
                return false;
            case 1:
                return true;
            case 2:
                return EvaluateTree(root.left) || EvaluateTree(root.right);
            case 3:
                return EvaluateTree(root.left) && EvaluateTree(root.right);
            default:
                return false;
        }

        return false;
    }
}