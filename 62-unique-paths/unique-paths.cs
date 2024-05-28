public class Solution {
    private int[,] grid;

    public int UniquePaths(int m, int n) {
        grid = new int[m, n];

        for (var i = m - 1; i >= 0; i--)
        {
            for (var j = n - 1; j >= 0; j--)
            {
                CountUniquePaths(i, j, m, n);
            }
        }

        return grid[0, 0];
    }

    private void CountUniquePaths(int x, int y, int m, int n)
    {
        if (grid[x, y] > 0)
        {
            return;
        }
        
        if (y == n - 1 || x == m - 1)
        {
            grid[x, y] = 1;
        }
        else
        {
            grid[x, y] = grid[x + 1, y] + grid[x, y + 1];
        }    
    }
}