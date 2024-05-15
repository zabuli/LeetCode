public class Solution {
    public int GetMaximumGold(int[][] grid) {
        var max = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != 0)
                {
                    max = Math.Max(max, GetMaximumGold(grid, i, j));
                }
            }
        }

        return max;
    }

    private int GetMaximumGold(int[][] grid, int x, int y)
    {
        if (x >= grid.Length || x < 0 || y >= grid[0].Length || y < 0
            || grid[x][y] == 0)
        {
            return 0;
        }

        var sum = 0;
        var currentValue = grid[x][y];

        grid[x][y] = 0;

        sum = Math.Max(sum, currentValue + GetMaximumGold(grid, x - 1, y));
        sum = Math.Max(sum, currentValue + GetMaximumGold(grid, x + 1, y));
        sum = Math.Max(sum, currentValue + GetMaximumGold(grid, x, y - 1));
        sum = Math.Max(sum, currentValue + GetMaximumGold(grid, x, y + 1));

        grid[x][y] = currentValue;

        return sum;
    }
}