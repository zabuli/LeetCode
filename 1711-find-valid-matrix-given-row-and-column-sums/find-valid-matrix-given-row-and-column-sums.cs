public class Solution {
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum) {
        var result = new int[rowSum.Length][];
        var rows = new int[rowSum.Length];
        var cols = new int[colSum.Length];

        for (var i = 0; i < rowSum.Length; i++)
        {
            result[i] = new int[colSum.Length];

            for (var j = 0; j < colSum.Length; j++)
            {
                result[i][j] = Math.Min(rowSum[i] - rows[i], colSum[j] - cols[j]);
                rows[i] += result[i][j];
                cols[j] += result[i][j];
            }
        }

        return result;
    }
}