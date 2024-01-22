public class Solution {
    public int[] FindErrorNums(int[] nums) {
        var duplicate = 0;
        var missingNumber = 0;
        var set = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (!set.ContainsKey(nums[i]))
            {
                set.Add(nums[i], i);
            }
            else
            {
               duplicate = nums[i];
            }
        }

        for (var i = 1; i <= nums.Length; i++)
        {
            if (!set.ContainsKey(i))
            {
                missingNumber = i;
            }
        }

        return new int[2] { duplicate, missingNumber };
    }
}