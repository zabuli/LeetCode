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
    public TreeNode CreateBinaryTree(int[][] descriptions) {
        var hashTable = GetHashTable(descriptions);
        hashTable = FillChildren(hashTable, descriptions);

        return GetParent(hashTable, descriptions);
    }

    private static Dictionary<int, TreeNode> GetHashTable(int[][] descriptions)
    {
        var hashTable = new Dictionary<int, TreeNode>();

        foreach (var description in descriptions) 
        {
            if (!hashTable.ContainsKey(description[0]))
            {
                hashTable.Add(description[0], new TreeNode(description[0]));
            }
            
            if (!hashTable.ContainsKey(description[1]))
            {
                hashTable.Add(description[1], new TreeNode(description[1]));
            }
        }

        return hashTable;
    }

    private Dictionary<int, TreeNode> FillChildren(Dictionary<int, TreeNode> hashTable, int[][] descriptions)
    {
        foreach (var description in descriptions)
        {
            if (description[2] == 1)
            {
                hashTable[description[0]].left = hashTable[description[1]];
            }
            else
            {
                hashTable[description[0]].right = hashTable[description[1]];
            }
        }

        return hashTable;
    }

    private TreeNode GetParent(Dictionary<int, TreeNode> hashTable, int[][] descriptions)
    {
        var children = new HashSet<int>();

        foreach (var description in descriptions)
        {
            if (!children.Contains(description[1]))
            {
                children.Add(description[1]);
            }
        }

        foreach (var description in descriptions)
        {
            if (!children.Contains(description[0]))
            {
                return hashTable[description[0]];
            }
        }

        return null;
    }
}