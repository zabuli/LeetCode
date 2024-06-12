public class Solution {
    public void SortColors(int[] nums) {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    var pom = nums[j];
                    nums[j] = nums[i];
                    nums[i] = pom;
                }
            }
        }
    }
}