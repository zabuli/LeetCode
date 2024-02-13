public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach(var word in words)
        {
            if (IsPalindrom(word))
            {
                return word;
            }
        }

        return "";
    }

    private static bool IsPalindrom(string word)
    {
        var j = word.Length - 1;
        for (var i = 0; i < word.Length; i++)
        {
            if (word[i] != word[j])
            {
                return false;
            }

            j--;
        }

        return true;
    }
}