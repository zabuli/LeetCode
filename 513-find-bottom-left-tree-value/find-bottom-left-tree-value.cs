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
    public int FindBottomLeftValue(TreeNode root) {
        var node = new TreeNode(root.val);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            node = queue.Dequeue();
            if (node.right != null)
            {
                queue.Enqueue(node.right);
            }
            if (node.left != null)
            {
                queue.Enqueue(node.left);
            }
        }

        return node.val;
    }
}