public class Solution {
    public bool WordPattern(string pattern, string s) {
        var hashMap = new Dictionary<char, string>();
        var words = s.Split(" ");

        if (pattern.Length != words.Length)
        {
            return false;
        }

        for (var i = 0; i < pattern.Length; i++)
        {
            if (hashMap.ContainsValue(words[i]))
            {
                if (!hashMap.ContainsKey(pattern[i]) || !hashMap[pattern[i]].Equals(words[i]))
                {
                    return false;
                }
            }

            if (!hashMap.ContainsKey(pattern[i]))
            {
                hashMap.Add(pattern[i], words[i]);
            }
            else if (!hashMap[pattern[i]].Equals(words[i]))
            {
                return false;
            }
        }

        return true;
    }
}