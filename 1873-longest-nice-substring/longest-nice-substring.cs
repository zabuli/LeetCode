public class Solution {    
    public string LongestNiceSubstring(string s) {
        var hashMap = new Dictionary<char, bool>();
        foreach(var c in s)
        {
            if (!hashMap.ContainsKey(c))
            {
                hashMap.Add(c, false);
            }
        }

        for (var i = 0; i < s.Length; i++)
        {
            if (!hashMap.ContainsKey(char.ToLower(s[i])) || !hashMap.ContainsKey(char.ToUpper(s[i])))
            {
                string l = LongestNiceSubstring(s.Substring(0, i));
                string p = LongestNiceSubstring(s.Substring(i + 1));
                return l.Length >= p.Length ? l : p;
            }
        }

        return s;
    }
}