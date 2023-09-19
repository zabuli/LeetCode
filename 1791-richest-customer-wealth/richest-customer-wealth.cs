public class Solution {
    public int MaximumWealth(int[][] accounts) {
        return accounts.Max(x => x.Sum());
    }
}