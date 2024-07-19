public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        IList<int> result = new List<int>();
        var mins = GetMins(matrix);
        var maxs = GetMaxs(matrix);

        foreach (var min in mins)
        {
            if (maxs.Contains(min))
            {
                result.Add(min);
            }
        }

        return result;
    }

    private static HashSet<int> GetMins(int[][] matrix)
    {
        var mins = new HashSet<int>();

        for (var i = 0; i < matrix.Length; i++)
        {
            mins.Add(matrix[i].Min());
        }

        return mins;
    }

    private static HashSet<int> GetMaxs(int[][] matrix)
    {
        var maxs = new HashSet<int>();
        var max = -1;

        for (var i = 0; i < matrix[0].Length; i++)
        {
            for (var j = 0; j < matrix.Length; j++)
            {
                max = Math.Max(max, matrix[j][i]);
            }

            maxs.Add(max);
            max = -1;
        }

        return maxs;
    }
}