public class Solution {
    public int MaxProfit(int[] prices) {
        var profit = 0;
        var diff = 0;
        var min = prices[0];
        for (var i = 0; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }
            diff = prices[i] - min;
            if(diff > profit)
            {
                profit = diff;
            }
        }

        return profit;
    }
}