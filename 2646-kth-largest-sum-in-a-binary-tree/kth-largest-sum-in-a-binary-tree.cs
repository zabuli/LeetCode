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
    public long KthLargestLevelSum(TreeNode root, int k) {
        var sums = GetSums(root);
        long result = -1;

        while (sums.Count > 0)
        {
            var sum = sums.Dequeue();
            k--;

            if (k == 0)
            {
                result = sum;
            }
        }

        return result;
    }

    private static PriorityQueue<long, long> GetSums(TreeNode root)
    {
        var sums = new PriorityQueue<long, long>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            long sum = 0;
            var count = q.Count;

            for (var i = 0; i < count; i++)
            {
                var node = q.Dequeue();
                sum += node.val;

                if (node.left != null)
                {
                    q.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    q.Enqueue(node.right);
                }
            }

            sums.Enqueue(sum, 0 - sum);
        }

        return sums;
    }
}