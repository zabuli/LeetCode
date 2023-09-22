public class Solution {
    public string RemoveOuterParentheses(string s) {
        var stack = new Stack<char>();
        var result = "";
        foreach(var c in s)
        {
            if (c == '(')
            {
                if (stack.Count > 0)
                {
                    result += c;
                }
                stack.Push(c);
            }
            else if (c == ')' && stack.Count > 0)
            {
                stack.Pop();
                if (stack.Count > 0)
                {
                    result += c;
                }
            }
        }

        return result;
    }
}