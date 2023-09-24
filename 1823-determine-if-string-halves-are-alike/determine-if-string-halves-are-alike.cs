public class Solution {
    public bool HalvesAreAlike(string s) {
        var halfCount = s.Length / 2;
        var s1 = s.Substring(0, halfCount);
        var s2 = s.Substring(halfCount, halfCount);
        return GetVowelsCount(s1) == GetVowelsCount(s2);
    }

    private static int GetVowelsCount(string s)
    {
        var result = 0;
        foreach(var c in s)
        {
            if(IsVowel(c))
            {
                result++;
            }
        }
        return result;
    }

    private static bool IsVowel(char c)
    {
        return "aeiouAEIOU".IndexOf(c) >= 0;
    }
}