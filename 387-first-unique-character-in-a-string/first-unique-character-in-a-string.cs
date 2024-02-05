public class Solution {
    public int FirstUniqChar(string s) {
        var set = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            if (!set.ContainsKey(s[i]))
            {
                set.Add(s[i], 0);
            }

            set[s[i]]++;
        }

        for (var i = 0; i < s.Length; i++)
        {
            if (set[s[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}