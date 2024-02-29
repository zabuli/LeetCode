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
    public bool IsEvenOddTree(TreeNode root) {
        int? prev = null;
        int size = 0; int level = 0;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            size = queue.Count;
            prev = null;

            for (var i = 0; i < size; i++)
            {
                var node = queue.Dequeue();

                if (level % 2 == 0)
                {
                    if (node.val % 2 == 0 || (prev.HasValue && prev.Value >= node.val))
                    {
                        return false;
                    }
                }
                else
                {
                    if (node.val % 2 != 0 || (prev.HasValue && prev.Value <= node.val))
                    {
                        return false;
                    }
                }

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }

                prev = node.val;
            }

            level++;
        }

        return true;
    }
}