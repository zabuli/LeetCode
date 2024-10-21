public class Solution {
    public int MaxUniqueSplit(string s) {
        return GetMaxUniqueSplit(s, 0, 0, new HashSet<string>());
    }

    public int GetMaxUniqueSplit(string s, int start, int max, HashSet<string> substrings)
    {
        if (start == s.Length)
        {
            return Math.Max(max, substrings.Count);
        }

        for (var i = start + 1; i <= s.Length; i++)
        {
            var substring = s.Substring(start, i - start);
            if (!substrings.Contains(substring))
            {
                substrings.Add(substring);
                max = GetMaxUniqueSplit(s, i, max, substrings);
                substrings.Remove(substring);
            }
        }

        return max;
    }
}