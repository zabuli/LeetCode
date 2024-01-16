public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        int sum;

        for (var i = 0; i < nums.Length; i++)
        {
            sum = target - nums[i];
            if (map.ContainsKey(sum))
            {
                return new int[2]{map[sum], i};
            }
            else
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
                else
                {
                    map.Add(nums[i], i); 
                }        
            }
        }

        return new int[2]{0, 1};
    }
}