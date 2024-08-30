public class Solution {
    public void ReverseString(char[] s) {
        var j = s.Length - 1;
        var pom = 'a';

        for (var i = 0; i < s.Length / 2; i++)
        {
            pom = s[i];
            s[i] = s[j];
            s[j] = pom;
            j--;
        }
    }
}