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
        var stack = new Stack<TreeNode>();
        var maxims = new Stack<int>();

        stack.Push(root);
        maxims.Push(root.val);

        while (stack.Count > 0)
        {
            var node = stack.Pop();
            var max = maxims.Pop();

            if (node.left != null)
            {
                if (node.left.val >= max)
                {
                    result++;
                }

                stack.Push(node.left);
                maxims.Push(Math.Max(max, node.left.val));
            }

            if (node.right != null)
            {
                if (node.right.val >= max)
                {
                    result++;
                }

                stack.Push(node.right);
                maxims.Push(Math.Max(max, node.right.val));
            }
        }

        return result;
    }
}