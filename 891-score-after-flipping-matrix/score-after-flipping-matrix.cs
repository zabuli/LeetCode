public class Solution {
    static int rowsCount = 0;
    static int columnsCount = 0;

    public int MatrixScore(int[][] grid) {
        if (grid == null)
        {
            return -1;
        }

        rowsCount = grid.Length;
        columnsCount = grid[0].Length;

        grid = FixFirstRow(grid);
        grid = FixRestOfTheGrid(grid);

        return CalculateFinalNumber(grid);
    }

    private int CalculateFinalNumber(int[][] grid) {
        var result = 0;
        var tmpResult = 0;

        for (int i = 0; i < grid.Length; i++) 
        {
            tmpResult = 0;

            for (int j = 0; j < grid[i].Length; j++) 
            {
                tmpResult = tmpResult * 2 + grid[i][j];
            }

            result += tmpResult;
        }

        return result;
    }

    private static int[][] FixRestOfTheGrid(int[][] grid)
    {
        for (var i = 1; i < columnsCount; i++)
        {
            var zeros = GetZerosCount(grid, i);
            if (zeros > rowsCount / 2)
            {
                grid = SwapColumn(grid, i);
            }
        }

        return grid;
    }

    private static int[][] FixFirstRow(int[][] grid)
    {
        var zeros = GetZerosCount(grid, 0);

        if (zeros == 0)
        {
            return grid;
        }

        for (var i = 0; i < rowsCount; i++)
        {
            if (grid[i][0] == 0)
            {
                grid = SwapRow(grid, i);
            }
        }

        return grid;
    }

    private static int GetZerosCount(int[][] grid, int row)
    {
        var zeros = 0;

        for (var i = 0; i < rowsCount; i++)
        {
            if (grid[i][row] == 0)
            {
                zeros++;
            }
        }

        return zeros;
    }

    private static int[][] SwapRow(int[][] grid, int row)
    {
        for (var i = 0; i < columnsCount; i++)
        {
            grid[row][i] = Swap(grid[row][i]);
        }

        return grid;
    }

    private static int[][] SwapColumn(int[][] grid, int column)
    {
        for (var i = 0; i < rowsCount; i++)
        {
            grid[i][column] = Swap(grid[i][column]);
        }

        return grid;
    }

    private static int Swap(int i)
    {
        return i == 1 ? 0 : 1;
    }
}