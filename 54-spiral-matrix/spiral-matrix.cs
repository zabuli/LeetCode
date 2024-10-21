public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        var list = new List<int>();
        var m = matrix.Length;
        var n = matrix[0].Length;
        var i = 0; var j = -1;
        var iEnd = m; var jEnd = n;
        var iStart = 1; var jStart = 0;

        while (list.Count < m * n)
        {
            while (j < jEnd - 1 && list.Count < m * n)
            {
                j++;
                list.Add(matrix[i][j]);
            }

            jEnd--;

            while (i < iEnd - 1 && list.Count < m * n)
            {
                i++;
                list.Add(matrix[i][j]);
            }

            iEnd--;

            while (j > jStart && list.Count < m * n)
            {
                j--;
                list.Add(matrix[i][j]);
            }

            jStart++;

            while (i > iStart && list.Count < m * n)
            {
                i--;
                list.Add(matrix[i][j]);
            }

            iStart++;
        }

        return list;
    }
}