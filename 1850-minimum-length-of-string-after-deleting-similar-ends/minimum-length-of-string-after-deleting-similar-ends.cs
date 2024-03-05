public class Solution {
    public int MinimumLength(string s) {
        if (s.Length < 2 || s[0] != s[s.Length - 1])
        {
            return s.Length;
        }

        var first = 0;
        var last = s.Length - 1;
        var pointer = s[first];

        while (first < last  && s[first] == s[last])
        {
            pointer = s[first];

            while (first <= last && s[first] == pointer)
            {
                first++;
            }
            while(first <= last && s[last] == pointer)
            {
                last--;
            }
        }

        return last - first + 1;
    }
}