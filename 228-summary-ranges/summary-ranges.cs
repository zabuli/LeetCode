public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        IList<string> result = new List<string>();

        if (nums.Length == 0)
        {
            return result;
        }

        var startPosition = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (i < nums.Length - 1 && nums[i] + 1 != nums[i + 1])
            {
                if (startPosition == i)
                {
                    result.Add(nums[i].ToString());
                }
                else
                {
                    result.Add(nums[startPosition].ToString() + "->" + nums[i].ToString());
                }
                
                startPosition = i + 1;
            }

            if (i == nums.Length - 1)
            {
                if (nums.Length > 1 && nums[i] == nums[i - 1] + 1)
                {
                    result.Add(nums[startPosition].ToString() + "->" + nums[i].ToString());
                }
                else
                {
                    result.Add(nums[i].ToString());
                }
            }
        }

        return result;
    }
}