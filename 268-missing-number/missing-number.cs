public class Solution {
    public int MissingNumber(int[] nums) {
        Array.Sort(nums);

        var min = 0; var max = nums.Length - 1;
        int mid;
        while(min <= max)
        {
            mid = (min + max) / 2;
            if (mid == nums[mid])
            {
                min = mid + 1;
            }
            else if (mid < nums[mid])
            {
                if (mid > 0 && nums[mid- 1] == mid - 1)
                {
                    return mid;
                }
                if (mid == 0 && nums[0] > 0)
                {
                    return 0;
                }
                max = mid - 1;
            }
            else if (mid == nums.Length - 1)
            {
                return mid + 1;
            }
        }

        return nums.Length;
    }
}