public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        var onesCount = GetOnesCount(s);
        var result = new StringBuilder();
        
        for(var i = 0; i < onesCount - 1; i++)
        {
            result.Append('1');
        }
        for (var i = onesCount - 1; i < s.Length - 1; i++)
        {
            result.Append('0');
        }

        result.Append('1');

        return result.ToString();
    }

    private static int GetOnesCount(string s)
    {
        var onesCount = 0;
        foreach(var c in s)
        {
            if (c == '1')
            {
                onesCount++;
            }
        }

        return onesCount;
    }
}