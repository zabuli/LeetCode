public class Solution {
    public int MaxWidthRamp(int[] nums) {
        var maxes = GetMaxes(nums);
        var maxWidth = 0;
        var i = 0;
        
        foreach (var max in maxes)
        {
            while (i < max.Value)
            {
                if (nums[i] <= max.Key)
                {
                    maxWidth = Math.Max(maxWidth, max.Value - i);
                }

                i++;
            }

            i = 0;
        }

        return maxWidth;
    }

    private static Dictionary<int, int> GetMaxes(int[] nums)
    {
        var max = -1;
        var result = new Dictionary<int, int>();

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                result.Add(nums[i], i);
            }
        }

        return result;
    }
}