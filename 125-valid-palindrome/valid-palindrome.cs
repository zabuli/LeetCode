public class Solution {
    public bool IsPalindrome(string s) {
        s = GetOnlyAlphaNumericCharacters(s);
        var isOddCount = s.Length % 2 != 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] != s[s.Length - 1 - i])
            {
                if (isOddCount && i == (s.Length / 2) - 1)
                {
                    continue;
                }

                return false;
            }
        }

        return true;
    }

    private static string GetOnlyAlphaNumericCharacters(string s)
    {
        var arr = s.ToCharArray();
        arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c))));
        return new string(arr).ToLower();
    }
}