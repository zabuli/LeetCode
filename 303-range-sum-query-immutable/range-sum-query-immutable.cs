public class NumArray {
    private int[] prefixSumNums;

    public NumArray(int[] nums) {
        prefixSumNums = new int[nums.Length];
        prefixSumNums[0] = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            prefixSumNums[i] = prefixSumNums[i - 1] + nums[i];
        }
    }
    
    public int SumRange(int left, int right) {
        if (left == 0)
        {
            return prefixSumNums[right];
        }
        
        return prefixSumNums[right] - prefixSumNums[left -1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */