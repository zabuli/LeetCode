public class Solution {
    public long MaxPoints(int[][] points) {
        var dp = GetDp(points);

        for (var i = 1; i < points.Length; i++)
        {
            var prevRow = dp[i - 1];
            var lefts = GetLeftToRightValues(prevRow);
            var rights = GetRightToLeftValues(prevRow);

            for (var j = 0; j < dp[0].Length; j++)
            {
                dp[i][j] = points[i][j] + Math.Max(lefts[j], rights[j]);
            }
        }

        return dp[dp.Length - 1].Max();
    }

    private static long[][] GetDp(int[][] points)
    {
        long[][] dp = new long[points.Length][];

        for (var i = 0; i < points.Length; i++)
        {
            dp[i] = new long[points[i].Length];
        }

        for (var i = 0; i < points[0].Length; i++)
        {
            dp[0][i] = points[0][i];
        }

        return dp;
    }

    private static long[] GetLeftToRightValues(long[] prewDpRow)
    {
        var result = new long[prewDpRow.Length];
        result[0] = prewDpRow[0];

        for (var i = 1; i < prewDpRow.Length; i++)
        {
            result[i] = Math.Max(result[i - 1] - 1, prewDpRow[i]);
        }

        return result;
    }

    private static long[] GetRightToLeftValues(long[] prewDpRow)
    {
        var result = new long[prewDpRow.Length];
        result[result.Length - 1] = prewDpRow[prewDpRow.Length - 1];

        for (var i = prewDpRow.Length - 2; i >= 0; i--)
        {
            result[i] = Math.Max(result[i + 1] - 1, prewDpRow[i]);
        }

        return result;
    }
}