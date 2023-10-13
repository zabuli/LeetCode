public class Solution {
    public string SortSentence(string s) {
        var arr = s.Split(" ");
        var dic = new Dictionary<int, string>();
        foreach(var ss in arr)
        {
            dic.Add(CharToInt(ss[ss.Length - 1]), ss);
        }
        var sortedDic = new SortedDictionary<int, string>(dic);
        return string.Join(" ", sortedDic.Select(x => x.Value.Substring(0, x.Value.Length - 1)));
    }

    private static int CharToInt(char c)
    {
        return c - '0';
    }
}