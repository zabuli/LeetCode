public class Solution {
    public int Rob(int[] nums) {
        var sum1 = 0;
        var sum2 = 0;
        var tmp = 0;

        foreach (var num in nums)
        {
            tmp = sum2;
            sum2 = Math.Max(sum1 + num, sum2);
            sum1 = tmp;
        }

        return sum2;
    }
}