public class Solution {
    public string CustomSortString(string order, string s) {
        int[] map = new int[26];
        
        foreach (char c in s) 
        {
            map[c - 'a']++;
        }

        var result = new System.Text.StringBuilder();

        foreach (char c in order) 
        {
            result.Append(new string(c, map[c - 'a']));
            map[c - 'a'] = 0;
        }

        for (int i = 0; i < 26; i++) 
        {
            result.Append(new string((char)('a' + i), map[i]));
        }

        return result.ToString();
    }
}