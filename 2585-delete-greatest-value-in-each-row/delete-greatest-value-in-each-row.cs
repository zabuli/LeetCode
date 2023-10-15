public class Solution {
    public int DeleteGreatestValue(int[][] grid) {
        var result = 0;
        var length = grid[0].Length;
        int max;

        for (var i = 0; i < length; i++)
        {
            max = 0;
            for (var j = 0; j < grid.Length; j++)
            {
                if (i == 0)
                {
                    Array.Sort(grid[j]);
                }
                if (max < grid[j][grid[j].Length - i - 1])
                {
                    max = grid[j][grid[j].Length - i - 1];
                }
            }

            result += max;
        }

        return result;
    }
}