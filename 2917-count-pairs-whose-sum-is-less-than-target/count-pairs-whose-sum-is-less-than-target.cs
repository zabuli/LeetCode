public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        var result = 0;
        var array = nums.ToArray();
        Array.Sort(array);

        for(var i = 0; i < array.Length; i++)
        {
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] < target)
                {
                    result++;
                }
            }   
        }

        return result;
    }
}