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
    public IList<int> InorderTraversal(TreeNode root) {
        if (root == null)
        {
            return new List<int>();
        }

        return GetList(root, new List<int>());
    }

    private IList<int> GetList(TreeNode root, IList<int> list)
    {
        if (root.left != null)
        {
            list = GetList(root.left, list);
        }
        if (root != null)
        {
            list.Add(root.val);
        }
        if (root.right != null)
        {
            list = GetList(root.right, list);
        }
        
        return list;
    }
}