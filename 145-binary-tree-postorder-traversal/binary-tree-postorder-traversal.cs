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
    public IList<int> PostorderTraversal(TreeNode root) {
        var result = new List<int>();

        if (root != null)
        {
            result.AddRange(PostorderTraversal(root.left));
            result.AddRange(PostorderTraversal(root.right));
            result.Add(root.val);
        }

        return result;
    }
}