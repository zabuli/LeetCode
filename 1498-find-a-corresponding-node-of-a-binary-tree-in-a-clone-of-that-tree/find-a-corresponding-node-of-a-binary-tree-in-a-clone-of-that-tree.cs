/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        return GetTreeNode(original, cloned, target);
    }

    private TreeNode GetTreeNode(TreeNode original, TreeNode  cloned, TreeNode target)
    {
        if (original == null) return null;
        if (original == target)
        {
            return cloned;
        }

        return GetTreeNode(original?.left, cloned?.left, target) ??
            GetTreeNode(original?.right, cloned?.right, target);
    }
}