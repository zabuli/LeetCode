public class Solution {
    public string RemoveKdigits(string num, int k) {
        var stack = GetStackWithResult(num, k);
        var reversedStack = GetReversedStack(stack);

        return GetResult(reversedStack);
    }

    private static Stack<char> GetStackWithResult(string num, int k)
    {
        var stackCount = num.Length - k;
        var stack = new Stack<char>();

        for (var i = 0; i < num.Length; i++)
        {
            while (k > 0 && stack.Count > 0 && num[i] < stack.Peek())
            {
                stack.Pop();
                k--;
            }

            stack.Push(num[i]);
        }

        while (stack.Count > 0 && stack.Count > stackCount)
        {
            stack.Pop();
        }

        return stack;
    }

    private static Stack<char> GetReversedStack(Stack<char> stack)
    {
        var result = new Stack<char>();

        while (stack.Count > 0)
        {
            result.Push(stack.Pop());
        }

        return result;
    }

    private static string GetResult(Stack<char> stack)
    {
        var sb = new StringBuilder();

        while (stack.Count > 0)
        {
            if (sb.Length == 0 && stack.Peek() == '0')
            {
                stack.Pop();
                continue;
            }

            sb.Append(stack.Pop());
        }

        return sb.Length == 0 ? "0" : sb.ToString();
    }
}