public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        return Math.Max(
            RobRange(nums, 0, nums.Length - 1),
            RobRange(nums, 1, nums.Length)
        );
    }

    public static int RobRange(int[] nums, int start, int end)
    {
        var sum1 = 0;
        var sum2 = 0;
        var tmp = 0;

        for (var i = start; i < end; i++)
        {
            tmp = sum2;
            sum2 = Math.Max(sum1 + nums[i], sum2);
            sum1 = tmp;
        }

        return sum2;
    }
}