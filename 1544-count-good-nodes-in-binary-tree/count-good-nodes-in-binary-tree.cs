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
        return GoodNodes(root, 1, root.val);
    }

    private int GoodNodes(TreeNode root, int count, int max)
    {
        if (root.left != null)
        {
            if (root.left.val >= max)
            {
                count++;
            }

            count = GoodNodes(root.left, count, Math.Max(max, root.left.val));
        }

        if (root.right != null)
        {
            if (root.right.val >= max)
            {
                count++;
            }

            count = GoodNodes(root.right, count, Math.Max(max, root.right.val));
        }

        return count;
    }
}