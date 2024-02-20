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

        var k = 0;
        for(var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[k])
            {
                var tmp = nums[k + 1];
                nums[k + 1] = nums[i];
                nums[i] = tmp;
                k += 2;
                i = k;
            }
        }

        return nums[k];
    }
}