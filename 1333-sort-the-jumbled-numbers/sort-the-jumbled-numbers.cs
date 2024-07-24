public class Solution {
    public int[] SortJumbled(int[] mapping, int[] nums) {
        var hashMap = MapNums(mapping, nums);
        hashMap = hashMap.OrderBy(x => x.Value).ToDictionary();

        return GetSortedArray(hashMap, nums);
    }

    private static int[] GetSortedArray(Dictionary<int, int> hashMap, int[] nums)
    {
        var result = new int[nums.Length];
        var counts = GetCounts(nums);
        var j = 0;

        foreach (var num in hashMap)
        {
            for (var i = 0; i < counts[num.Key]; i++)
            {
                result[j] = num.Key;
                j++;
            }
        }

        return result;
    }

    private static Dictionary<int, int> GetCounts(int[] nums)
    {
        var hashMap = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!hashMap.ContainsKey(num))
            {
                hashMap.Add(num, 0);
            }

            hashMap[num]++;
        }

        return hashMap;
    }

    private static Dictionary<int, int> MapNums(int[] mapping, int[] nums)
    {
        var hashMap = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!hashMap.ContainsKey(num))
            {
                hashMap.Add(num, GetMappedValue(num, mapping));
            }
        }

        return hashMap;
    }

    private static int GetMappedValue(int num, int[] mapping)
    {
        if (num < 10)
        {
            return mapping[num];
        }

        var result = 0;
        var count = 0;

        while (num > 0)
        {
            var x = num % 10;
            x = (int)(Math.Pow(10, count)) * mapping[x];
            result += x;
            num /= 10;
            count++;
        }

        return result;
    }
}