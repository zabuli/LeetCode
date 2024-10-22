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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var list = new List<IList<int>>();

        if (root == null)
        {
            return list;
        }
        
        var queue = new Queue<TreeNode>();
        var k = 0;
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var count = queue.Count;
            var j = k % 2 == 0 ? 0 : count - 1;

            list.Add(new int[count]);
            
            for (var i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                list[k][j] = node.val;

                if (k % 2 == 0)
                {
                     j++;
                }
                else
                {
                    j--;
                }
            
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            k++;
        }

        return list;
    }
}