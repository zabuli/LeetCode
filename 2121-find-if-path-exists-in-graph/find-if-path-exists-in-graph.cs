public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        if (n < 2)
        {
            return true;
        }

        var arr = GetSet(n, edges);
        return Find(arr, source) == Find(arr, destination);
    }

    private static int[] GetSet(int n, int[][] edges)
    {
        var arr = new int[n];
        for (var i = 0; i < n; i++)
        {
            arr[i] = i;
        }

        int p; int q;
        foreach(var edge in edges)
        {
            p = Find(arr, edge[0]);
            q = Find(arr, edge[1]);
            arr[q] = p;
        }

        return arr;
    }

    private static int Find(int[] arr, int i)
    {
        if (arr[i] == i)
        {
            return i;
        }

        return Find(arr, arr[i]);
    }
}