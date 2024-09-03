public class Solution {
    public int GetLucky(string s, int k) {
        s = GetTransformedString(s);

        return GetKTransformation(s, k);
    }

    private static int GetKTransformation(string s, int k)
    {
        var num = GetTransformation(s);

        for (var i = 1; i < k; i++)
        {
            num = GetTransformation(num.ToString());
        }

        return num;
    }

    private static int GetTransformation(string s)
    {
        var num = 0;

        foreach (var c in s)
        {
            num += c - '0';
        }

        return num;
    }

    private static string GetTransformedString(string s)
    {
        var sb = new StringBuilder();

        foreach (var c in s)
        {
            sb.Append(GetNumber(c));
        }

        return sb.ToString();
    }

    private static int GetNumber(char c)
    {
        return (int)c % 32;
    }
}