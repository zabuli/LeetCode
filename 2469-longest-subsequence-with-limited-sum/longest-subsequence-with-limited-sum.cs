public class Solution {
    public int[] AnswerQueries(int[] nums, int[] queries) {
        Array.Sort(nums);

        for(var i = 0; i < nums.Length - 1; i++)
        {
            nums[i + 1] += nums[i];
        }
    
        var result = new int[queries.Length];

        for(var i = 0; i < queries.Length; i++)
        {
            if (nums[0] > queries[i])
            {
                result[i] = 0;
                continue;
            }

            result[i] = GetAnswer(nums, queries[i]);
        }

        return result;
    }

    private static int GetAnswer(int[] nums, int query)
    {
        var min = 0; var max = nums.Length - 1;
        var result = 0; int mid;
        while(min <= max)
        {
            mid = min + ((max - min) / 2);
            if (nums[mid] == query)
            {
                result = mid + 1;
                break;
            }
            else
            {
                if (nums[mid] < query)
                {
                    min = mid + 1;
                    if (min > max)
                    {
                        result = mid + 1;
                    }
                }
                else
                {
                    max = mid - 1;
                    if (min > max)
                    {
                        result = mid;
                    }
                }
            }
        }

        return result;
    }
}