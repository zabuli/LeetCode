public class Solution {
    public string MinRemoveToMakeValid(string s) {
        var result = string.Empty;
        var stack = new Stack<char>();
        var rightCount = s.Count(c => c == ')');
    
        foreach(var c in s)
        {
            if (c == ')')
            {
                rightCount--;

                if (stack.Count == 0)
                {
                    continue;
                }

                stack.Pop();
            }

            if (c == '(')
            {
                if (rightCount == 0 || rightCount <= stack.Count)
                {
                    continue;
                }

                stack.Push(c);
            }

            result += c;
        }

        return result;
    }
}