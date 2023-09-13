public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var result = new int[cost.Length + 1];
        Array.Copy(cost, 0, result, 0, cost.Length);
        for(var i = 2; i < result.Length; i++)
        {
            result[i] += Math.Min(result[i - 1], result[i - 2]);
        }

        return result[result.Length - 1];
    }
}