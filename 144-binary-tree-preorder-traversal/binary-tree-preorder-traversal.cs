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
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> data = new List<int>();
        return PreorderTraversal(root, data);
    }

    private IList<int> PreorderTraversal(TreeNode root, IList<int> data)
    {
        if (root == null)
        {
            return data;
        }

        data.Add(root.val);

        if (root.left != null)
        {
            data = PreorderTraversal(root.left, data);
        }
        if (root.right != null)
        {
            data = PreorderTraversal(root.right, data);
        }

        return data;
    }
}