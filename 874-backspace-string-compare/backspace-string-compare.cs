public class Solution {
    public bool BackspaceCompare(string s, string t) {
        var stackS = GetFilledStack(s);
        var stackT = GetFilledStack(t);

        return stackS.SequenceEqual(stackT);
    }

    private static Stack<char> GetFilledStack(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c == '#' && stack.Count > 0)
            {
                stack.Pop();
            }
            else if (c != '#')
            {
                stack.Push(c);
            }
        }

        return stack;
    }
}