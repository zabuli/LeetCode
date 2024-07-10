/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null)
        {
            return null;
        }
        
        var originNodes = GetNodes(head);
        var copyNodes = GetCopyNodes(originNodes);
        var index = 0;

        for (var i = 0; i < copyNodes.Count; i++)
        {
            index = GetNodeIndex(originNodes, originNodes[i].random);

            if (i < copyNodes.Count - 1)
            {
                copyNodes[i].next = copyNodes[i + 1];
            }
            
            if (index > -1)
            {
                copyNodes[i].random = copyNodes[index];
            }
        }

        return copyNodes[0];
    }

    private List<Node> GetNodes(Node head)
    {
        var nodes = new List<Node>();

        while (head != null)
        {
            nodes.Add(head);
            head = head.next;
        }

        return nodes;
    }

    private List<Node> GetCopyNodes(List<Node> nodes)
    {
        var result = new List<Node>();

        foreach (var node in nodes)
        {
            result.Add(new Node(node.val));
        }

        return result;
    }

    private static int GetNodeIndex(List<Node> nodes, Node node)
    {
        for (var i = 0; i < nodes.Count; i++)
        {
            if (nodes[i].Equals(node))
            {
                return i;
            }
        }

        return -1;
    }
}