public class Solution {
    public int MajorityElement(int[] nums) {
        var set = new Dictionary<int, int>();

        foreach(var num in nums)
        {
            if (!set.ContainsKey(num))
            {
                set.Add(num, 0);
            }

            set[num]++;
            if (set[num] > nums.Length / 2)
            {
                return num;
            }
        }

        return -1;
    }
}