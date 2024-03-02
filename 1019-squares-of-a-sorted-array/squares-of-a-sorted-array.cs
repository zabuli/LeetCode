public class Solution {
    public int[] SortedSquares(int[] nums) {
        var result = new int[nums.Length];
        var left = 0;
        var right = nums.Length - 1;
        var index = right;

        while(left <= right)
        {
            var leftSquare = nums[left] * nums[left];
            var rightSquare = nums[right] * nums[right];

            if (leftSquare > rightSquare)
            {
                result[index] = leftSquare;
                left++;
            }
            else
            {
                result[index] = rightSquare;
                right--;
            }

            index--;
        }

        return result;        
    }
}