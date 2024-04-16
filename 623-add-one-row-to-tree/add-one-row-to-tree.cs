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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        return AddOneRow(root, val, depth, 1);
    }

    private TreeNode AddOneRow(TreeNode root, int val, int depth, int currentDepth)
    {
        if (root == null)
        {
            return new TreeNode(val);
        }
        if (depth == 1)
        {
            var node = new TreeNode(val);
            node.left = root;
            return node;
        }

        if (currentDepth < depth - 1)
        {
            if (root.left != null)
            {
                root.left = AddOneRow(root.left, val, depth, currentDepth + 1);
            }
            if (root.right != null)
            {
                root.right = AddOneRow(root.right, val, depth, currentDepth + 1);
            }
        }
        else
        {
            var node = new TreeNode(val);
            node.left = root.left;
            root.left = node;
                
            node = new TreeNode(val);
            node.right = root.right;
            root.right = node;
        }

        return root;
    }
}