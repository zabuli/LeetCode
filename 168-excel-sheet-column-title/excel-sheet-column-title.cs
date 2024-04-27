public class Solution {
    public string ConvertToTitle(int columnNumber) {
        var alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        var result = new StringBuilder();

        while (columnNumber > 0)
        {
            var index = (columnNumber - 1) % 26;
            result.Insert(0, alpha[index]);
            columnNumber = (columnNumber - 1) / 26;
        }

        return result.ToString();
    }
}