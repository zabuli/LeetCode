public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        var count = 0;
        var prevSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            prevSum  = nums[i];
            
            if (nums[i] == goal)
            {
                count++;
            }

            for (var j = i + 1; j < nums.Length; j++)
            {
                prevSum += nums[j];

                if (prevSum == goal)
                {
                    count++;
                }

                if (prevSum > goal)
                {
                    break;
                }
            }
        }

        return count;
    }
}