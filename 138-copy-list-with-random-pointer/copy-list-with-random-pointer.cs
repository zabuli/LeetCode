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
        
        var nodes = GetNodes(head);
        
        foreach (var node in nodes)
        {
            if (node.Key.next != null)
            {
                node.Value.next = nodes[node.Key.next];
            }
            
            if (node.Key.random != null)
            {
                node.Value.random = nodes[node.Key.random];
            }
        }

        return nodes[head];
    }

    private Dictionary<Node, Node> GetNodes(Node head)
    {
        var result = new Dictionary<Node, Node>();

        while (head != null)
        {
            result.Add(head, new Node(head.val));
            head = head.next;
        }

        return result;
    }
}