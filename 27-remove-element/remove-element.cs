public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var k = 0; var i = 0;
        while (i < nums.Length)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }

            i++;
        }

        return k;
    }
}