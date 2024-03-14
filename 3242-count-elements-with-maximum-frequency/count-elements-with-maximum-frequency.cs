public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        var frequencies = GetFrequencies(nums);
        
        return GetMaxFrequencyElements(nums, frequencies);
    }

    private static int GetMaxFrequencyElements(int[] nums, Dictionary<int, int> frequencies)
    {
        var result = 0;
        var max = frequencies.Values.Max();

        for (var i = 0; i < nums.Length; i++)
        {
            if(frequencies[nums[i]] == max)
            {
                result++;
            }
        }

        return result;
    }

    private static Dictionary<int, int> GetFrequencies(int[] nums)
    {
        var frequencies = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (!frequencies.ContainsKey(nums[i]))
            {
                frequencies.Add(nums[i], 0);
            }

            frequencies[nums[i]]++;
        }

        return frequencies;
    }
}