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
    public TreeNode InvertTree(TreeNode root) {
        if (root == null)
        {
            return null;
        }

        var node = new TreeNode(root.val);
        return ReverseTree(node, root);
    }

    private TreeNode ReverseTree(TreeNode node, TreeNode root)
    {
        if (root == null)
        {
            return node;
        }
        if (root.right != null)
        {
            node.left = new TreeNode(root.right.val);
            node.left = ReverseTree(node.left, root.right);
        }
        if (root.left != null)
        {
            node.right = new TreeNode(root.left.val);
            node.right = ReverseTree(node.right, root.left);
        }
        
        return node;
    }
}