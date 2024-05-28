public class Solution {
    private int count = 0;
    private HashSet<int> cols = new HashSet<int>();
    private HashSet<int> pos = new HashSet<int>();
    private HashSet<int> neg = new HashSet<int>();

    public int TotalNQueens(int n) {
        BackTrack(0, n);
        return count;
    }

    private void BackTrack(int row, int n)
    {
        if (row == n)
        {
            count++;
        }

        for (var col = 0; col < n; col++)
        {
            if (!isColValid(row, col))
            {
                continue;
            }

            Add(row, col);
            BackTrack(row + 1, n);
            Remove(row, col);
        }
    }

    private bool isColValid(int row, int col)
    {
        return !cols.Contains(col) && !pos.Contains(row + col) && !neg.Contains(row - col);
    }

    private void Add(int row, int col)
    {
        cols.Add(col);
        pos.Add(row + col);
        neg.Add(row - col);
    }

    private void Remove(int row, int col)
    {
        cols.Remove(col);
        pos.Remove(row + col);
        neg.Remove(row - col);
    }
}