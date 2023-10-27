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
    public TreeNode InvertTree(TreeNode root) {
        if (root == null)
        {
            return null;
        }

        var stack = new Stack<TreeNode>();
        stack.Push(root);
        var node = new TreeNode(root.val); 
        var result = node;
        TreeNode tmp;
        while(stack.Count > 0)
        {
            node = stack.Pop();
            if (node == null)
            {
                continue;
            }

            tmp = node.right;
            node.right = node.left;
            node.left = tmp;
            
            stack.Push(node.right);
            stack.Push(node.left);
        }

        return root;
    }
}