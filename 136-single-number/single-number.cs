public class Solution {
    public int SingleNumber(int[] nums) {
        if (nums.Length == 0)
        {
            return 0;
        }
        if (nums.Length == 1)
        {
            return nums[0];
        }

        var result = nums[0];
        for(var i = 1; i < nums.Length; i++)
        {
            result ^= nums[i];
        }

        return result;
    }
}