public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] - nums[i] == diff)
                {
                    for (var k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[k] - nums[j] == diff)
                        {
                            result++;
                        }
                    }
                }
            }
        }

        return result;
    }
}