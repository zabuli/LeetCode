public class Solution {
    public bool CheckValidString(string s) {
        var stackLeft = new Stack<int>();
        var stackRight = new Stack<int>();

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stackLeft.Push(i);
            }

            if (s[i] == ')')
            {
                if (stackLeft.Count > 0)
                {
                    stackLeft.Pop();
                }
                else
                {
                    stackRight.Push(i);
                }
            }
        }

        if (stackLeft.Count > 0 || stackRight.Count > 0)
        {
            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '*')
                {
                    if (stackLeft.Count > 0 && stackLeft.Peek() < i)
                    {
                        stackLeft.Pop();
                    }
                    else if (stackRight.Count > 0 && stackRight.Peek() > i)
                    {
                        stackRight.Pop();
                    }

                    if (stackLeft.Count == 0 && stackRight.Count == 0)
                    {
                        break;
                    }
                }
            }
        }
        
        return stackLeft.Count == 0 && stackRight.Count == 0;
    }
}