public class Solution {
    public int MaxProductDifference(int[] nums) {
        var min1 = 1000000; var max1 = 0;
        var min2 = 1000000; var max2 = 0;

        foreach(var num in nums)
        {
            if (min1 >= num)
            {
                min2 = min1;
                min1 = num;
            }
            if (min2 >= num && min1 != num)
            {
                min2 = num;
            }
            if (max1 <= num)
            {
                max2 = max1;
                max1 = num;
            }
            if (max2 <= num && max1 != num)
            {
                max2 = num;
            }
        }

        return (max1 * max2) - (min1 * min2);
    }
}