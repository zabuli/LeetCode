public class Solution {
    public int ScoreOfString(string s) {
        var bytes = Encoding.ASCII.GetBytes(s);
        var result = 0;

        for (var i = 0; i < bytes.Length - 1; i++)
        {
            result += Math.Abs(bytes[i] - bytes[i + 1]);
        }

        return result;
    }
}