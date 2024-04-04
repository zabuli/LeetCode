public class Solution {
    public int MaxDepth(string s) {
        var depth = 0;
        var maxDepth = 0;

        foreach(var c in s)
        {
            if (c == '(')
            {
                depth++;
                maxDepth = Math.Max(depth, maxDepth);
            }

            if (c == ')')
            {
                depth--;
            }
        }

        return maxDepth;
    }
}