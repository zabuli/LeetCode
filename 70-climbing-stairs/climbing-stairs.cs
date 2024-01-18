public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 2)
        {
            return n;
        }
        var a = 1; var b = 2; var c = 0;
        for (var i = 2; i < n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }
}