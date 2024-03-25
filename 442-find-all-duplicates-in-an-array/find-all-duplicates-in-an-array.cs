public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var dict = new Dictionary<int, int>();

        foreach(var num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict.Add(num, 0);
            }

            dict[num]++;
        }

        return dict.Where(x => x.Value > 1).Select(x => x.Key).ToList();
    }
}