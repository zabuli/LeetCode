public class Solution {
    public int FindMaxK(int[] nums) {
        var result = -1;
        var negatives = GetNegatives(nums);
        
        foreach (var num in nums)
        {
            if (num < 0)
            {
                continue;
            }
            if (result < num && negatives.Contains(num * (-1)))
            {
                result = num;
            }
        }

        return result;
    }

    private static HashSet<int> GetNegatives(int[] nums)
    {
        var set = new HashSet<int>();

        foreach (var num in nums)
        {
            if (num < 0)
            {
                set.Add(num);
            }
        }

        return set;
    }
}