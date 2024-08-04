public class Solution {
    public int RangeSum(int[] nums, int n, int left, int right) {
        var sumList = CreateSumList(nums);
        sumList = sumList.OrderBy(x => x).ToList();

        return GetSum(sumList, left, right);
    }

    private static int GetSum(List<int> sumList, int left, int right)
    {
        long sum = 0;

        for (var i = left - 1; i < right; i++)
        {
            sum += sumList[i];
        }

        return (int)(sum % 1000000007);
    }

    private static List<int> CreateSumList(int[] nums)
    {
        var result = new List<int>();
        
        for (var i = 0; i < nums.Length; i++)
        {
            result.Add(nums[i]);

            for (var j = i + 1; j < nums.Length; j++)
            {
                result.Add(result[result.Count - 1] + nums[j]);
            }
        }

        return result;
    }
}