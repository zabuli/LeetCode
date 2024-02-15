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
    public bool IsSymmetric(TreeNode root) {
        if (root.left == null && root.right == null)
        {
            return true;
        }
        var left = GetLeft(root.left, new List<int?>());
        var right = GetRight(root.right, new List<int?>());

        return left.SequenceEqual(right);
    }

    private List<int?> GetLeft(TreeNode node, List<int?> list)
    {
        if (node == null)
        {
            list.Add(null);
            return list;
        }

        list.Add(node.val);
        list = GetLeft(node.left, list);
        list = GetLeft(node.right, list);

        return list;
    }

    private List<int?> GetRight(TreeNode node, List<int?> list)
    {
        if (node == null)
        {
            list.Add(null);
            return list;
        }

        list.Add(node.val);
        list = GetRight(node.right, list);
        list = GetRight(node.left, list);
 
        return list;
    }
}