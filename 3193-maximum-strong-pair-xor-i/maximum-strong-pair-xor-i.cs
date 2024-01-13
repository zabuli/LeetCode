public class Solution {
    public int MaximumStrongPairXor(int[] nums) {
        var max = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i; j < nums.Length; j++)
            {
                if (IsStrongPair(nums[i], nums[j]))
                {
                    max = Math.Max(max, nums[i] ^ nums[j]);
                }
            }
        }

        return max;
    }

    private static bool IsStrongPair(int x, int y)
    {
        return Math.Abs(x - y) <= Math.Min(x, y);
    }
}