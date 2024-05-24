public class Solution {
    public void MoveZeroes(int[] nums) {
        var slow = 0;
        var fast = 0;

        while(fast < nums.Length)
        {
            if (nums[fast] != 0)
            {
                nums[slow] = nums[fast];
                slow++;
            }

            fast++;
        }

        for (var i = slow; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}