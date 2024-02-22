public class Solution {
    public int FindJudge(int n, int[][] trust) {
        if (trust.Length == 0)
        {
            return n == 1 ? 1 : -1;
        }

        var zeros = new int[n + 1];
        var dict = new Dictionary<int, int>();
        var set = new HashSet<int>();
        foreach(var x in trust)
        {
            zeros[x[0]]++;
            if (!dict.ContainsKey(x[1]))
            {
                dict.Add(x[1], 0);
            }

            dict[x[1]]++;
            if (!set.Contains(x[0]))
            {
                set.Add(x[0]);
            }
            if (!set.Contains(x[1]))
            {
                set.Add(x[1]);
            }
        }

        var result = dict.FirstOrDefault(x => x.Value == set.Count - 1);
        if (result.Equals(default(KeyValuePair<int,int>)))
        {
            return -1;
        }

        return zeros[result.Key] == 0 ? result.Key : -1;
    }
}