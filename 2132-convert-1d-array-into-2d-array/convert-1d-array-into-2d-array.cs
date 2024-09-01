public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        if (original.Length > m * n)
        {
            return new int[0][]{};
        }

        var result = new int[m][];
        var k = 0;

        for (var i = 0; i < m; i++)
        {
            result[i] = new int[n];

            for (var j = 0; j < n; j++)
            {
                if (k > original.Length - 1)
                {
                    return new int[0][]{};
                }

                result[i][j] = original[k];
                k++;
            }
        }

        return result;
    }
}