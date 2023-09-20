public class Solution {
    public int SumIndicesWithKSetBits(IList<int> nums, int k) {
        var result = 0;
        for(var i = 0; i < nums.Count; i++)
        {
            if (GetBinaryNumber(i).Count(x => x == 1) == k)
            {
                result += nums[i];
            }
        }
        return result;
    }

    public static List<int> GetBinaryNumber(int number)
    {
        var result = new List<int>();
        while(number > 0)
        {
            if (number % 2 == 0)
            {
                result.Add(0);
            }
            else
            {
                result.Add(1);
            }
            number = number / 2;
        }
        return result;
    }
}