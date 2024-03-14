public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        var dict = new HashSet<int>(nums1);
        
        foreach(var num in nums2)
        {
            if (dict.Contains(num))
            {
                return num;
            }
        }

        return -1;
    }
}