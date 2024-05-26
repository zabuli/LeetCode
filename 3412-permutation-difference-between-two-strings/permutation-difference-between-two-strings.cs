public class Solution {
    public int FindPermutationDifference(string s, string t) {
        var dict = new Dictionary<char, int>();
        var sum = 0;

        for (var i =  0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i]))
            {
                dict.Add(s[i], i);
            }
            else
            {
                sum += Math.Abs(i - dict[s[i]]);
            }

            if (!dict.ContainsKey(t[i]))
            {
                dict.Add(t[i], i);
            }
            else
            {
                sum += Math.Abs(dict[t[i]] - i);
            }
        }

        return sum;
    }
}