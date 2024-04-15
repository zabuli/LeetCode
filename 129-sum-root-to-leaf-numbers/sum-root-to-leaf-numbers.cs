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
    public int SumNumbers(TreeNode root) {
        var sum = 0;

        if (root == null)
        {
            return sum;
        }
        
        var lists = new List<List<int>>();
        lists.Add(new List<int>());
        lists = Dfs(root, lists);

        foreach (var list in lists)
        {
            sum += list
                .Select((t, i) => t * Convert.ToInt32(Math.Pow(10, list.Count - i - 1)))
                .Sum();
        }

        return sum;
    }

    private List<List<int>> Dfs(TreeNode root, List<List<int>> lists)
    {
        if (root == null)
        {
            return lists;
        }

        lists.Last().Add(root.val);
        var rightList = new List<int>(lists.Last());

        if (root.left != null)
        {
            lists = Dfs(root.left, lists);
        }
        if (root.right != null)
        {
            if (root.left != null)
            {
                lists.Add(rightList);
            }
            
            lists = Dfs(root.right, lists);
        }

        return lists;
    }
}