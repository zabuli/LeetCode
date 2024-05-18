public class Solution {
    public bool CanJump(int[] nums) {
        if (nums.Length == 1)
        {
            return true;
        }

        if (GetLastPossibleIndex(nums, 0, new HashSet<int>()) == nums.Length - 1)
        {
            return true;
        }

        return false;
    }

    private int GetLastPossibleIndex(int[] nums, int i, HashSet<int> visitedIndices)
    {
        if (i < nums.Length - 1 && nums[i] == 0)
        {
            return -1;
        }

        if (i >= nums.Length - 1)
        {
            return nums.Length - 1;
        }

        if (visitedIndices.Contains(i))
        {
            return -1;
        }

        visitedIndices.Add(i);

        for (var j = 1; j <= nums[i]; j++)
        {
            if (GetLastPossibleIndex(nums, i + j, visitedIndices) == nums.Length - 1)
            {
                return nums.Length - 1;
            }
        }
        
        return -1;
    }
}