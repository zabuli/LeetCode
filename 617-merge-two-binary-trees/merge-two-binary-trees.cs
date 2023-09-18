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
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        var result = GetNode(root1, root2);
        return GetTree(result, root1, root2);
    }

    public TreeNode GetTree(TreeNode origin, TreeNode root1, TreeNode root2)
    {
        if (origin == null)
        {
            return origin;
        }

        origin.left = GetNode(root1?.left, root2?.left);
        origin.right = GetNode(root1?.right, root2?.right);

        if (origin.left == null && origin.right == null)
        {
            return origin;
        }
        
        origin.left = GetTree(origin.left, root1?.left, root2?.left);
        origin.right = GetTree(origin.right, root1?.right, root2?.right);
        
        return origin;
    }

    public TreeNode GetNode(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 == null)
        {
            return null;
        }
        if (root1 == null)
        {
            return new TreeNode(root2.val);
        }
        if (root2 == null)
        {
            return new TreeNode(root1.val);
        }

        return new TreeNode(root1.val + root2.val);
    }
}