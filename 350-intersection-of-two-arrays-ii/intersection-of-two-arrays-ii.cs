public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        return nums1.Length <= nums2.Length
            ? GetIntersect(GetElements(nums1), nums2)
            : GetIntersect(GetElements(nums2), nums1);
    }

    private static Dictionary<int, int> GetElements(int[] nums)
    {
        var result = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!result.ContainsKey(num))
            {
                result.Add(num, 0);
            }

            result[num]++;
        }

        return result;
    }

    private static int[] GetIntersect(Dictionary<int, int> nums1, int[] nums2)
    {
        var result = new List<int>();

        foreach (var num in nums2)
        {
            if (nums1.ContainsKey(num) && nums1[num] > 0)
            {
                result.Add(num);
                nums1[num]--;
            }
        }

        return result.ToArray();
    }
}