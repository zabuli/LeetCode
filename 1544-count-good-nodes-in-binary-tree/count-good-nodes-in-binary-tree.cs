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
    public int GoodNodes(TreeNode root) {
        var result = 1;
        var maxims = new Queue<int>();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        maxims.Enqueue(root.val);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            var maxim = maxims.Dequeue();
            
            if (node.left != null)
            {
                if (maxim <= node.left.val)
                {
                    result++;
                }

                maxims.Enqueue(Math.Max(maxim, node.left.val));
                queue.Enqueue(node.left);
            }
            
            if (node.right != null)
            {
                if (maxim <= node.right.val)
                {
                    result++;
                }

                maxims.Enqueue(Math.Max(maxim, node.right.val));
                queue.Enqueue(node.right);
            }
        }

        return result;
    }
}