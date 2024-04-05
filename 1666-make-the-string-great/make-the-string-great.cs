public class Solution {
    public string MakeGood(string s) {
        var stack = GetStack(s);

        return GetGoodString(stack);
    }

    private static string GetGoodString(Stack<char> stack)
    {
        var arr = stack.ToArray();
        Array.Reverse(arr);
        
        return new string(arr);
    }

    private static Stack<char> GetStack(string s)
    {
        var stack = new Stack<char>();

        for(var i = 0; i < s.Length; i++)
        {
            if (stack.Count > 0)
            {
                var lastChar = stack.Peek();

                if (IsOneCharUpper(lastChar, s[i]) 
                    && char.ToLower(lastChar) == char.ToLower(s[i]))
                {   
                    stack.Pop();
                    continue;
                }
            }

            stack.Push(s[i]);
        }

        return stack;
    }

    private static bool IsOneCharUpper(char c1, char c2)
    {
        return (char.IsUpper(c1) && !(char.IsUpper(c2)))
            || (char.IsUpper(c2) && !(char.IsUpper(c1)));
    }
}