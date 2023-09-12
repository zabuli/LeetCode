public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        var result = 0;
        var hashTable = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++)
        {
            if (!hashTable.ContainsKey(nums[i]))
            {
                hashTable.Add(nums[i], 1);
            }
            else
            {                
                result += hashTable[nums[i]];
                hashTable[nums[i]]++;
            }
        }

        return result;
    }
}