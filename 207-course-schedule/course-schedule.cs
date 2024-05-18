public class Solution {
    private class TreeNode
    {
        public int Value { get; set; }
        public List<TreeNode> Nodes { get; set; } = new List<TreeNode>();
        public HashSet<int> Visited { get; set; } = new HashSet<int>();

        public TreeNode(int value)
        {
            Value = value;
        }
    }
    
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var nodes = CreateTreeNodes(prerequisites);
        
        foreach (var node in nodes)
        {
            if (IsCycle(node, node.Value))
            {
                return false;
            }
        } 

        return true;
    }

    private bool IsCycle(TreeNode node, int value)
    {
        if (node == null)
        {
            return false;
        }

        if (node.Visited.Contains(value))
        {
            return false;
        }

        node.Visited.Add(value);

        for (var i = 0; i < node.Nodes.Count; i++)
        {
            if (node.Nodes[i].Value == value)
            {
                return true;
            }
            if (IsCycle(node.Nodes[i], value))
            {
                return true;
            }
        }

        return false;
    }

    private static List<TreeNode> CreateTreeNodes(int[][] prerequisites)
    {
        var nodes = new Dictionary<int, TreeNode>();

        for (var i = 0; i < prerequisites.Length; i++)
        {
            if (!nodes.ContainsKey(prerequisites[i][0]))
            {
                nodes.Add(prerequisites[i][0], new TreeNode(prerequisites[i][0]));
            }

            if (!nodes.ContainsKey(prerequisites[i][1]))
            {
                nodes.Add(prerequisites[i][1], new TreeNode(prerequisites[i][1]));
            }

            nodes[prerequisites[i][0]].Nodes.Add(nodes[prerequisites[i][1]]);
        }

        return nodes.Select(x => x.Value).ToList();
    }
}