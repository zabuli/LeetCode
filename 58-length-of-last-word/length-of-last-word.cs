public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        var lastSpaceIndex = s.LastIndexOf(" ");
        return s.Length - lastSpaceIndex - 1;
    }
}