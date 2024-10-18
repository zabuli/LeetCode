public class Solution {
    public int CountMaxOrSubsets(int[] nums) {
        var maxOr = GetMaxOr(nums);
        return GetOrCount(nums, 0, 0, maxOr, 0);
    }

    private int GetOrCount(int[] nums, int i, int currentOr, int maxOr, int count)
    {
        if (i == nums.Length)
        {
            if (currentOr == maxOr)
            {
                count++;
            }

            return count;
        }

        count = GetOrCount(nums, i+ 1, currentOr | nums[i], maxOr, count);
        count = GetOrCount(nums, i+ 1, currentOr, maxOr, count);

        return count;
    }

    private static int GetMaxOr(int[] nums)
    {
        var maxOr = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            maxOr |= nums[i];
        }

        return maxOr;
    }
}