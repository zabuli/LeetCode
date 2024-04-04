public class Solution {
    public int MaxDepth(string s) {
        var stack = new Stack<char>();
        var depth = 0;
        var maxDepth = 0;

        foreach(var c in s)
        {
            if (c == '(')
            {
                stack.Push(c);
                depth = stack.Count;
                maxDepth = Math.Max(depth, maxDepth);
            }

            if (c == ')')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
        }

        return maxDepth;
    }
}