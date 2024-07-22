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
    public IList<string> BinaryTreePaths(TreeNode root) {
        IList<string> result = new List<string>();

        result = GetPaths(root, root.val.ToString(), result);

        return result;
    }

    private IList<string> GetPaths(TreeNode root, string path, IList<string> paths)
    {
        if (root == null)
        {
            return null;
        }

        if (root.left == null && root.right == null)
        {
            paths.Add(path);
            return paths;
        }

        if (root.left != null)
        {
            paths = GetPaths(root.left, path + "->" + root.left.val.ToString(), paths);
        }

        if (root.right != null)
        {
            paths = GetPaths(root.right, path + "->" + root.right.val.ToString(), paths);
        }

        return paths;
    }
}