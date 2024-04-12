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
        return PostOrder(root, new List<int>());
    }

    private IList<int> PostOrder(TreeNode root, IList<int> nodes)
    {
        if (root == null)
        {
            return nodes;
        }
        if (root.left != null)
        {
             nodes = PostOrder(root.left, nodes);
        }
        if (root.right != null)
        {
            nodes = PostOrder(root.right, nodes);
        }
        
        nodes.Add(root.val);

        return nodes;
    }
}