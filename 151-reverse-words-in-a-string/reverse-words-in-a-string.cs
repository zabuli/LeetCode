public class Solution {
    public string ReverseWords(string s) {
        var stack = GetWords(s);
        var sb = new StringBuilder();

        while (stack.Count > 0)
        {
            var word = stack.Pop();
            sb.Append(word);

            if (stack.Count > 0)
            {
                sb.Append(" ");
            }
        }

        return sb.ToString();
    }

    private static Stack<string> GetWords(string s)
    {
        s = s.Trim();
        var stack = new Stack<string>();
        var i = 0;
        var sb = new StringBuilder();

        while (i < s.Length)
        {
            while (i < s.Length && s[i] != ' ')
            {
                sb.Append(s[i]);
                i++;
            }

            stack.Push(sb.ToString());
            sb.Clear();

            while (i < s.Length && s[i] == ' ')
            {
                i++;
            }
        }

        return stack;
    }
}