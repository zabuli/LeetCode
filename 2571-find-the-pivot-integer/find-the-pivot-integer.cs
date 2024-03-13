public class Solution {
    public int PivotInteger(int n) {
        var sum1 = GetSum1(n);
        var sum2 = GetSum2(n);
       
        return GetPivot(sum1, sum2, n);
    }

    private static int[] GetSum1(int n)
    {
        var sum1 = new int[n];
        sum1[0] = 1;

        for (var i = 1; i < n - 1; i++)
        {
            sum1[i] = sum1[i - 1] + (i + 1);
        }

        return sum1;
    }

    private static int[] GetSum2(int n)
    {
        var sum2 = new int[n];
        sum2[n - 1] = n;
        for (var j = n - 2; j > 1; j--)
        {
            sum2[j] = sum2[j + 1] + (j + 1);
        }

        return sum2;
    }

    private static int GetPivot(int[] sum1, int[] sum2, int n)
    {
        for (var k = 0; k < n; k++)
        {
            if (sum1[k] == sum2[k])
            {
                return k + 1;
            }
        }

        return -1;
    }
}