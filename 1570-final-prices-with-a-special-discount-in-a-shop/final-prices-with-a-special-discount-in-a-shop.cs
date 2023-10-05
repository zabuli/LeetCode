public class Solution {
    public int[] FinalPrices(int[] prices) {
        var stack = new Stack();
        for (var i = 0; i < prices.Length; i++)
        {
            for (var j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] <= prices[i])
                {
                    stack.Push(prices[j]);
                    break;
                }
            }
            
            if (stack.Count > 0)
            {
                prices[i] -= (int)stack.Pop();
            }
        }

        return prices;
    }
}