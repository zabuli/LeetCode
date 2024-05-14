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
    public TreeNode IncreasingBST(TreeNode root) {
        if (root == null)
        {
            return null;
        }

        var values = InorderBST(root, new List<int>());
        root = new TreeNode(values[0]);
        var node = root;

        if (values.Count > 1)
        {
            for (var i = 1; i < values.Count; i++)
            {
                node.right = new TreeNode(values[i]);
                node = node.right;
            }
        }

        return root;
    }

    private List<int> InorderBST(TreeNode node, List<int> values)
    {
        if (node == null)
        {
            return values;
        }

        values = InorderBST(node.left, values);
        values.Add(node.val);
        values = InorderBST(node.right, values);

        return values;
    }
}