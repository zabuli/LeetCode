public class Solution {
    public int MinDifference(int[] nums) {
        if (nums.Length < 5)
        {
            return 0;
        }

        Array.Sort(nums);

        var min = Int32.MaxValue;
        var counter = 0;
        var left = 0; 
        var right = nums.Length - 4; 

        while (counter < 4)
        {
            min = Math.Min(min, nums[right] - nums[left]);
            counter++;
            left++;
            right++;
        }

        return min;
    }
}