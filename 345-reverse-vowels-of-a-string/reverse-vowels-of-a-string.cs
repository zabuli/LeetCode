public class Solution {
    private static HashSet<char> Vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    public string ReverseVowels(string s) {
        var sb = new StringBuilder();
        var j = s.Length - 1;

        for (var i = 0; i < s.Length; i++)
        {
            if (Vowels.Contains(s[i]))
            {
                while (!Vowels.Contains(s[j]))
                {
                    j--;
                }

                sb.Append(s[j]);
                j--;
            }
            else
            {
                sb.Append(s[i]);
            }
        }

        return sb.ToString();
    }
}