public class Solution {
    public string ReverseParentheses(string s) {
        var stack = new Stack<int>();

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else if (s[i] == ')')
            {
                var start = stack.Pop();
                var substring = GetReversedString(s.Substring(start + 1, i - start - 1));
                s = s.Remove(start + 1, substring.Length).Insert(start + 1, substring);
            }
        }

        s = s.Replace(")", "").Replace("(", "");

        return s;
    }

    private static string GetReversedString(string s)
    {
        var arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}