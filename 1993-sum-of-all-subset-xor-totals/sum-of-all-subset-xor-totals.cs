public class Solution {
    public int SubsetXORSum(int[] nums)
    {
        var result = nums.Sum();

        for (var i = 1; i < nums.Length; i++)
        {
            result += GetXOR(nums, i, nums[i - 1]);
        }

        return result;
    }

    private int GetXOR(int[] nums, int index, int element)
    {
        var result = 0;
        
        if (index == nums.Length - 1)
        {
            result += element ^ nums[^1];
        }
        else
        {
            result = element ^ nums[index];
            result += GetXOR(nums, index + 1, result);
            result += GetXOR(nums, index + 1, element);
        }

        return result;
    }
}