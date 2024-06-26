public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var dict = GetCharacters(t);
        var result = string.Empty;

        for (var i = 0; i < t.Length; i++)
        {
            if (dict[t[i]] == '1' && !dict.ContainsValue(s[i]))
            {
                dict[t[i]] = s[i];
            }

            result += dict[t[i]];
        }

        return result.Equals(s);
    }

    private static Dictionary<char, char> GetCharacters(string s)
    {
        var dict = new Dictionary<char, char>();

        foreach(var c in s)
        {
            if (!dict.ContainsKey(c))
            {
                dict.Add(c, '1');
            }
        }

        return dict;
    }
}