public class Solution {
    public int NthUglyNumber(int n) {
        var p2 = 0; var p3 = 0; var p5 = 0;
        var dp = new int[n];
        dp[0] = 1;

        for (var i = 1; i < n; i++)
        {
            var pp2 = dp[p2] * 2;
            var pp3 = dp[p3] * 3;
            var pp5 = dp[p5] * 5;

            dp[i] = Math.Min(pp2, Math.Min(pp3, pp5));
            
            if (dp[i] == pp2) p2++;
            if (dp[i] == pp3) p3++;
            if (dp[i] == pp5) p5++;
        }

        return dp[n - 1];
    }
}