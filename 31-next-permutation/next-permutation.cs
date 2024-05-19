public class Solution {
    public void NextPermutation(int[] nums) {
        if (nums.Length == 1)
        {
            return;
        }

        var isChange = false;

        //4 3 2 3 1
        //4 3 3 1 2
        //1 2 3
        //1 3 2

        for (var i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i + 1] > nums[i])
            {
                var indexOfMinValue = GetIndexOfMinValue(nums, i, i + 1);
                Swap(nums, i, indexOfMinValue);
                SwapPartialArray(nums, i + 1);
                
                isChange = true;
                break;
            }
        }

        if (!isChange)
        {
            for (var i = 0 ; i < nums.Length / 2; i++)
            {
                Swap(nums, nums.Length - 1 - i, i);
            }
        }
    }

    private static int GetIndexOfMinValue(int[] nums, int currentValueIndex, int comparedValueIndex)
    {
        var index = comparedValueIndex;

        for (var i = currentValueIndex + 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[currentValueIndex] && nums[i] < nums[index])
            {
                index = i;
            }
        }

        return index;
    }

    private void SwapPartialArray(int[] nums, int from)
    {
        for (var j = 0; j < nums.Length - from; j++)
        {
            for (var i = from; i < nums.Length - j - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    Swap(nums, i, i + 1);
                }
            }
        }
    }

    private void Swap(int[] nums, int i, int j)
    {
        var tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp;
    }
}