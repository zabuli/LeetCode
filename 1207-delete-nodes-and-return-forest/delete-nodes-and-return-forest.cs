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
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) {
        IList<TreeNode> nodes = new List<TreeNode>();

        if (root == null)
        {
            return nodes;
        }

        (nodes, root) = GetNodes(root, to_delete, !to_delete.Contains(root.val), nodes);

        return nodes;
    }

    private (IList<TreeNode>, TreeNode) GetNodes(TreeNode root, int[] to_delete, bool isRoot, IList<TreeNode> nodes)
    {
        if (root == null)
        {
            return (nodes, root);
        }

        var isDeleted = to_delete.Contains(root.val);
        (nodes, root.left) = GetNodes(root.left, to_delete, isDeleted, nodes);
        (nodes, root.right) = GetNodes(root.right, to_delete, isDeleted, nodes);

        if (isDeleted)
        {
            root = null;
        }
        else if (isRoot)
        {
            nodes.Add(root);
        }

        return (nodes, root);
    }
}