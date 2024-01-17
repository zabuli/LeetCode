public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var k = 0; int i = 1;
        while (i < nums.Length)
        {
            if (nums[k] != nums[i])
            {
                nums[k + 1] = nums[i];
                k++;
            }
            i++;
        }

        return k + 1;
    }
}