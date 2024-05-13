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
    public IList<double> AverageOfLevels(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        TreeNode node;
        double sum = 0;
        var queCount = 0;
        var nodesCount = 0;
        IList<double> result = new List<double>();

        while (queue.Count > 0)
        {
            sum = 0;
            queCount = queue.Count;
            nodesCount = queue.Count;

            while (queCount > 0)
            {
                node = queue.Dequeue();
                queCount--;
                sum += node.val;

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            sum /= nodesCount;
            result.Add(sum);
        }

        return result;
    }
}