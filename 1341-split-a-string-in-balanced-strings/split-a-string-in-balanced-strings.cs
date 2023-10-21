public class Solution {
    public int BalancedStringSplit(string s) {
        var result = 0;
        var countR = 0; var countL = 0;

        foreach(var c in s)
        {
            if (c == 'L')
            {
                countL++;
            }
            else
            {
                countR++;
            }
            if (countL == countR)
            {
                result++;
                countL = 0;
                countR = 0;
            }
        }

        return result;
    }
}