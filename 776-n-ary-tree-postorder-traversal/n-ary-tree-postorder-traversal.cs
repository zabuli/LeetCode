/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Postorder(Node root) {
        var result = new List<int>();

        if (root == null)
        {
            return result;
        }

        foreach (var child in root.children)
        {
            result.AddRange(Postorder(child));
        }

        result.Add(root.val);

        return result;
    }
}